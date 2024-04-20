using Emgu.CV;
using Emgu.CV.Structure;

namespace lab1
{
  internal class Filters
  {
    public Filters() { }

    public static Image<Gray, byte> GetGrayImage(ref Image<Bgr, byte> source){
      return source.Convert<Gray, byte>();
    }

    public static Image<Bgr, byte> ApplyToImage(ref Image<Bgr, byte> source, int cannyThreshold, int cannyThresholdLinking) {
      var grayImage = GetGrayImage(ref source);

      var tempImage = grayImage.PyrDown();
      var destImage = tempImage.PyrUp();

      Image<Gray, byte> cannyEdges = destImage.Canny(cannyThreshold, cannyThresholdLinking);

      var cannyEdgesBgr = cannyEdges.Convert<Bgr, byte>();
      var resultImage = source.Sub(cannyEdgesBgr);

      for (int channel = 0; channel < resultImage.NumberOfChannels; channel++)
      {
        for (int x = 0; x < resultImage.Width; x++)
        {
          for (int y = 0; y < resultImage.Height; y++)
          {
            byte color = resultImage.Data[y, x, channel];
            if (color <= 50)
              color = 0;
            else if (color <= 100)
              color = 25;
            else if (color <= 150)
              color = 180;
            else if (color <= 200)
              color = 210;
            else
              color = 255;
            resultImage.Data[y, x, channel] = color;
          }
        }
      }

      return resultImage;
    }
  }
}
