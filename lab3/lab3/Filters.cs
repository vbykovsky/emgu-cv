using System;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace lab3
{
  internal class Filters
  {
    public static Image<Bgr, byte> ApplyScale(Image<Bgr, byte> sourceImage, float sX, float sY)
    {
      int newWidth = (int)(sourceImage.Width * sX);
      int newHeight = (int)(sourceImage.Height * sY);
      var newImage = new Image<Bgr, byte>(newWidth, newHeight);

      for (int x = 0; x < newWidth; x++)
      {
        for (int y = 0; y < newHeight; y++)
        {
          int floorX = (int)Math.Floor(x / sX);
          int floorY = (int)Math.Floor(y / sY);

          float ratioX = x / sX - floorX;
          float ratioY = y / sY - floorY;

          int baseX = Math.Min(floorX, sourceImage.Width - 2);
          int baseY = Math.Min(floorY, sourceImage.Height - 2);

          float invRatioX = 1 - ratioX;
          float invRatioY = 1 - ratioY;

          Bgr newVal = new Bgr(
            (sourceImage[baseY, baseX].Blue * invRatioX + sourceImage[baseY, baseX + 1].Blue * ratioX) * invRatioY +
            (sourceImage[baseY + 1, baseX].Blue * invRatioX + sourceImage[baseY + 1, baseX + 1].Blue * ratioX) * ratioY,

            (sourceImage[baseY, baseX].Green * invRatioX + sourceImage[baseY, baseX + 1].Green * ratioX) * invRatioY +
            (sourceImage[baseY + 1, baseX].Green * invRatioX + sourceImage[baseY + 1, baseX + 1].Green * ratioX) * ratioY,

            (sourceImage[baseY, baseX].Red * invRatioX + sourceImage[baseY, baseX + 1].Red * ratioX) * invRatioY +
            (sourceImage[baseY + 1, baseX].Red * invRatioX + sourceImage[baseY + 1, baseX + 1].Red * ratioX) * ratioY
          );

          newImage[y, x] = newVal;
        }
      }

      return newImage;
    }

    public static Image<Bgr, byte> ApplyShift(Image<Bgr, byte> sourceImage, float shift)
    {
      var processedImage = new Image<Bgr, byte>(sourceImage.Width, sourceImage.Height);

      for (int y = 0; y < sourceImage.Height; y++)
      {
        for (int x = 0; x < sourceImage.Width; x++)
        {
          int newX = (int)(x + shift * (sourceImage.Height - y));
          int newY = y;

          if (newX >= 0 && newX < sourceImage.Width)
          {
            processedImage[newY, newX] = sourceImage[y, x];
          }
        }
      }

      return processedImage;
    }

    public static Bgr BilinearInterpolation(Bgr c1, Bgr c2, Bgr c3, Bgr c4, double ratioX, double ratioY)
    {
      double blue = (1 - ratioX) * (1 - ratioY) * c1.Blue + ratioX * (1 - ratioY) * c2.Blue +
                    (1 - ratioX) * ratioY * c3.Blue + ratioX * ratioY * c4.Blue;
      double green = (1 - ratioX) * (1 - ratioY) * c1.Green + ratioX * (1 - ratioY) * c2.Green +
                      (1 - ratioX) * ratioY * c3.Green + ratioX * ratioY * c4.Green;
      double red = (1 - ratioX) * (1 - ratioY) * c1.Red + ratioX * (1 - ratioY) * c2.Red +
                    (1 - ratioX) * ratioY * c3.Red + ratioX * ratioY * c4.Red;

      return new Bgr(blue, green, red);
    }


    public static Image<Bgr, byte> ApplyRotation(Image<Bgr, byte> sourceImage, double angle, int centerX, int centerY)
    {
      Image<Bgr, byte> rotatedImage = new Image<Bgr, byte>(sourceImage.Width, sourceImage.Height);

      double radians = angle * Math.PI / 180.0;
      double invRadians = -radians;

      for (int y = 0; y < rotatedImage.Height; y++)
      {
        for (int x = 0; x < rotatedImage.Width; x++)
        {
          double srcX = (x - centerX) * Math.Cos(invRadians) - (y - centerY) * Math.Sin(invRadians) + centerX;
          double srcY = (x - centerX) * Math.Sin(invRadians) + (y - centerY) * Math.Cos(invRadians) + centerY;

          int baseX = (int)Math.Floor(srcX);
          int baseY = (int)Math.Floor(srcY);

          double ratioX = srcX - baseX;
          double ratioY = srcY - baseY;

          if (baseX < 0 || baseY < 0 || baseX >= sourceImage.Width - 1 || baseY >= sourceImage.Height - 1)
            continue;

          Bgr c1 = sourceImage[baseY, baseX];
          Bgr c2 = sourceImage[baseY, baseX + 1];
          Bgr c3 = sourceImage[baseY + 1, baseX];
          Bgr c4 = sourceImage[baseY + 1, baseX + 1];

          Bgr interpolatedColor = BilinearInterpolation(c1, c2, c3, c4, ratioX, ratioY);

          rotatedImage[y, x] = interpolatedColor;
        }
      }

      return rotatedImage;
    }

    public static Image<Bgr, byte> ApplyMirror(Image<Bgr, byte> sourceImage)
    {
      var processedImage = sourceImage.Clone();

      for (int y = 0; y < processedImage.Height; y++)
      {
        for (int x = 0; x < processedImage.Width / 2; x++)
        {
          var temp = processedImage.Data[y, x, 0];
          processedImage.Data[y, x, 0] = processedImage.Data[y, processedImage.Width - 1 - x, 0];
          processedImage.Data[y, processedImage.Width - 1 - x, 0] = temp;

          temp = processedImage.Data[y, x, 1];
          processedImage.Data[y, x, 1] = processedImage.Data[y, processedImage.Width - 1 - x, 1];
          processedImage.Data[y, processedImage.Width - 1 - x, 1] = temp;

          temp = processedImage.Data[y, x, 2];
          processedImage.Data[y, x, 2] = processedImage.Data[y, processedImage.Width - 1 - x, 2];
          processedImage.Data[y, processedImage.Width - 1 - x, 2] = temp;
        }
      }

      return processedImage;
    }

    public static Image<Bgr, byte> ApplyProjection(Image<Bgr, byte> sourceImage, PointF[] srcPoints)
    {
      PointF[] destPoints =
      {
        new PointF(0, 0),
        new PointF(sourceImage.Width - 1, 0),
        new PointF(sourceImage.Width - 1, sourceImage.Height - 1),
        new PointF(0, sourceImage.Height - 1)
      };

      var homographyMatrix = CvInvoke.GetPerspectiveTransform(srcPoints, destPoints);

      var destImage = new Image<Bgr, byte>(sourceImage.Size);
      CvInvoke.WarpPerspective(sourceImage, destImage, homographyMatrix, destImage.Size);

      return destImage;
    }

  }
}
