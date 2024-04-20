using System;
using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace lab2
{
  internal class Filters
  {
    public static byte ClampValue(double value, double min = 0, double max = 255)
    {
      return (byte)Math.Max(min, Math.Min(max, value));
    }

    public static Image<Gray, byte> ApplyGreyFilter(Image<Bgr, byte> sourceImage)
    {
      var greyImage = new Image<Gray, byte>(sourceImage.Size);

      for (int y = 0; y < sourceImage.Rows; y++)
      {
        for (int x = 0; x < sourceImage.Cols; x++)
        {
          greyImage.Data[y, x, 0] = Convert.ToByte(
            0.299 * sourceImage.Data[y, x, 2] +
            0.587 * sourceImage.Data[y, x, 1] +
            0.114 * sourceImage.Data[y, x, 0]
          );
        }
      }

      return greyImage;
    }

    public static Image<Bgr, byte> ApplySepiaFilter(Image<Bgr, byte> sourceImage)
    {
      Image<Bgr, byte> sepiaImage = sourceImage.Clone();

      for (int y = 0; y < sourceImage.Height; y++)
      {
        for (int x = 0; x < sourceImage.Width; x++)
        {
          Bgr pixel = sourceImage[y, x];

          double blue = (0.272 * pixel.Blue) + (0.534 * pixel.Green) + (0.131 * pixel.Red);
          double green = (0.349 * pixel.Blue) + (0.686 * pixel.Green) + (0.168 * pixel.Red);
          double red = (0.393 * pixel.Blue) + (0.769 * pixel.Green) + (0.189 * pixel.Red);

          blue = Math.Min(blue, 255);
          green = Math.Min(green, 255);
          red = Math.Min(red, 255);

          sepiaImage[y, x] = new Bgr(blue, green, red);
        }
      }

      return sepiaImage;
    }

    public static Image<Bgr, byte> ApplyGammaCorrection(Image<Bgr, byte> image, double gamma)
    {
      Image<Bgr, byte> correctedImage = image.CopyBlank();

      for (int y = 0; y < image.Height; y++)
      {
        for (int x = 0; x < image.Width; x++)
        {
          byte blue = image.Data[y, x, 0];
          byte green = image.Data[y, x, 1];
          byte red = image.Data[y, x, 2];

          byte correctedBlue = (byte)Math.Min(255, Math.Pow(blue / 255.0, 1.0 / gamma) * 255.0);
          byte correctedGreen = (byte)Math.Min(255, Math.Pow(green / 255.0, 1.0 / gamma) * 255.0);
          byte correctedRed = (byte)Math.Min(255, Math.Pow(red / 255.0, 1.0 / gamma) * 255.0);

          correctedImage.Data[y, x, 0] = correctedBlue;
          correctedImage.Data[y, x, 1] = correctedGreen;
          correctedImage.Data[y, x, 2] = correctedRed;
        }
      }

      return correctedImage;
    }

    public static Image<Bgr, byte> ApplyBrightness(Image<Bgr, byte> image, int brightness)
    {
      return image.Add(new Bgr(brightness, brightness, brightness));
    }

    public static Image<Bgr, byte> ApplyMedianBlur(Image<Bgr, byte> sourceImage, int kernelSize)
    {
      int halfKernelSize = kernelSize / 2;
      Image<Bgr, byte> resultImage = sourceImage.CopyBlank();

      for (int y = 0; y < sourceImage.Height; y++)
      {
        for (int x = 0; x < sourceImage.Width; x++)
        {
          List<byte> blueValues = new List<byte>();
          List<byte> greenValues = new List<byte>();
          List<byte> redValues = new List<byte>();

          for (int i = -halfKernelSize; i <= halfKernelSize; i++)
          {
            for (int j = -halfKernelSize; j <= halfKernelSize; j++)
            {
              int neighborX = x + j;
              int neighborY = y + i;

              if (neighborX >= 0 && neighborX < sourceImage.Width && neighborY >= 0 && neighborY < sourceImage.Height)
              {
                Bgr pixel = sourceImage[neighborY, neighborX];
                blueValues.Add((byte)pixel.Blue);
                greenValues.Add((byte)pixel.Green);
                redValues.Add((byte)pixel.Red);
              }
            }
          }

          blueValues.Sort();
          greenValues.Sort();
          redValues.Sort();
          byte medianBlue = blueValues[blueValues.Count / 2];
          byte medianGreen = greenValues[greenValues.Count / 2];
          byte medianRed = redValues[redValues.Count / 2];
          resultImage[y, x] = new Bgr(medianBlue, medianGreen, medianRed);
        }
      }

      return resultImage;
    }


    public static Image<Bgr, byte> ApplyWindowFilter(Image<Bgr, byte> sourceImage)
    {
        double[,] kernel = { };
        Image<Bgr, byte> resultImage = sourceImage.CopyBlank();

        for (int y = 1; y < sourceImage.Height - 1; y++)
        {
            for (int x = 1; x < sourceImage.Width - 1; x++)
            {
                double blue = 0, green = 0, red = 0;
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        blue += sourceImage[y + i, x + j].Blue * kernel[i + 1, j + 1];
                        green += sourceImage[y + i, x + j].Green * kernel[i + 1, j + 1];
                        red += sourceImage[y + i, x + j].Red * kernel[i + 1, j + 1];
                    }
                }

                byte clippedBlue = (byte)Math.Max(0, Math.Min(255, blue));
                byte clippedGreen = (byte)Math.Max(0, Math.Min(255, green));
                byte clippedRed = (byte)Math.Max(0, Math.Min(255, red));

                resultImage[y, x] = new Bgr(clippedBlue, clippedGreen, clippedRed);
            }
        }

        return resultImage;
    }

    public static Image<Bgr, byte> ApplyWatercolorFilter(Image<Bgr, byte> sourceImage, Image<Bgr, byte> originalMaskImage)
    {
      var filteredImage = new Image<Bgr, byte>(sourceImage.Size);
      CvInvoke.AddWeighted(sourceImage, 0.5, originalMaskImage, 0.5, 0, filteredImage);

      return filteredImage;
    }

    public static Image<Bgr, byte> ApplyCartoonFilter(Image<Bgr, byte> sourceImage, int thresholdValue)
    {
      Image<Gray, byte> grayImage = sourceImage.Convert<Gray, byte>().PyrDown().PyrUp();

      grayImage = grayImage.SmoothMedian(9);

      grayImage = grayImage.ThresholdBinary(new Gray(thresholdValue), new Gray(255));

      Image<Gray, byte> cannyEdges = grayImage.Canny(100, 50);

      cannyEdges = cannyEdges.Dilate(3);

      Image<Gray, byte> mask = cannyEdges.Convert<Gray, byte>().Not();

      Image<Bgr, byte> cartoonImage = sourceImage.And(new Bgr(255, 255, 255), mask);

      return cartoonImage;
    }
    public static Image<Bgr, byte>AdjustBrightness(Image<Bgr, byte> filteredImage, int value)
    {
      Image<Bgr, byte> bgrImage = filteredImage.Clone();

      for (int y = 0; y < bgrImage.Height; y++)
      {
        for (int x = 0; x < bgrImage.Width; x++)
        {
          Bgr pixel = bgrImage[y, x];
          bgrImage[y, x] = new Bgr(ClampValue(pixel.Blue + value), ClampValue(pixel.Green + value), ClampValue(pixel.Red + value));
        }
      }

      return bgrImage;
    }

    public static Image<Bgr, byte> AdjustContrast(Image<Bgr, byte> filteredImage, double value)
    {
      Image<Bgr, byte> bgrImage = filteredImage.Clone();

      for (int y = 0; y < bgrImage.Height; y++)
      {
        for (int x = 0; x < bgrImage.Width; x++)
        {
          Bgr pixel = bgrImage[y, x];
          bgrImage[y, x] = new Bgr(ClampValue((pixel.Blue - 127) * value + 127), ClampValue((pixel.Green - 127) * value + 127), ClampValue((pixel.Red - 127) * value + 127));
        }
      }

      return bgrImage;
    }


    public static Image<Bgr, byte>  ApplyMatrixFilter(Image<Bgr, byte> sourceImage, float[,] filterMatrix)
    {
      float[] filterArray = new float[9];
      int index = 0;
      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          filterArray[index] = filterMatrix[i, j];
          index++;
        }
      }

      Mat kernel = new Mat(3, 3, DepthType.Cv32F, 1);
      kernel.SetTo(filterArray);

      Image<Bgr, byte> filteredImage = sourceImage.CopyBlank();
      CvInvoke.Filter2D(sourceImage, filteredImage, kernel, new Point(-1, -1));

      return filteredImage;
    }


    public static Image<Bgr, byte> ApplyHSVValue(Image<Hsv, byte> hsvImage, Hsv hsv)
    {
      Image<Hsv, byte> modifiedHsvImage = hsvImage.Copy();

      modifiedHsvImage = modifiedHsvImage.Add(hsv);

      Image<Bgr, byte> resultImage = modifiedHsvImage.Convert<Bgr, byte>();

      return resultImage;
    }

  }
}
