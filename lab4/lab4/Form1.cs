using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace lab4
{
  public partial class Form1 : Form
  {
    private Image<Bgr, byte> sourceImage;
    private Image<Bgr, byte> processedImage;
    private Image<Bgr, byte> regionsImage;

    private double thresholdValue = 80.0;
    private double minContourArea = 99.0;

    public Form1()
    {
        InitializeComponent();
    }

    private void button_open_image_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      var result = openFileDialog.ShowDialog();
      if (result == DialogResult.OK)
      {
        string fileName = openFileDialog.FileName;
        sourceImage = new Image<Bgr, byte>(fileName);

        imageBox1.Image = sourceImage;
        imageBox1.SizeMode = PictureBoxSizeMode.Zoom;

      }
    }

    private void button_remove_noise_Click(object sender, EventArgs e)
    {
      processedImage = sourceImage.Clone();
      imageBox2.Image = processedImage;
      if (sourceImage != null)
      {
        var grayImage = sourceImage.Convert<Gray, byte>();
        int kernelSize = 5;
        var bluredImage = grayImage.SmoothGaussian(kernelSize);

        processedImage = bluredImage.Convert<Bgr, byte>();
        imageBox2.Image = processedImage;
        imageBox2.SizeMode = PictureBoxSizeMode.Zoom;
      }
    }

    private void button_detect_regions_Click(object sender, EventArgs e)
    {
      if (processedImage != null)
      {
        var grayImage = processedImage.Convert<Gray, byte>();
        var threshold = new Gray(thresholdValue);
        var color = new Gray(255);
        var binarizedImage = grayImage.ThresholdBinary(threshold, color);

        regionsImage = binarizedImage.Convert<Bgr, byte>();
        imageBox2.Image = regionsImage;
        imageBox2.SizeMode = PictureBoxSizeMode.Zoom;
      }
    }

    private void button_find_contours_Click(object sender, EventArgs e)
    {
      if (regionsImage != null)
      {
        VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
        CvInvoke.FindContours(regionsImage.Convert<Gray, byte>(), contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

        var contoursImage = sourceImage.CopyBlank();
        for (int i = 0; i < contours.Size; i++)
        {
            var points = contours[i].ToArray();
            contoursImage.Draw(points, new Bgr(Color.GreenYellow), 2);
        }

        processedImage = contoursImage;
        imageBox2.Image = processedImage;
        imageBox2.SizeMode = PictureBoxSizeMode.Zoom;
      }
    }

    private void button_find_primitives_Click(object sender, EventArgs e)
    {
      if (regionsImage != null)
      {
        VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
        CvInvoke.FindContours(regionsImage.Convert<Gray, byte>(), contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

        int triangleCount = 0;
        var primitivesImage = sourceImage.CopyBlank();

        for (int i = 0; i < contours.Size; i++)
        {
          var approxContour = new VectorOfPoint();
          CvInvoke.ApproxPolyDP(contours[i], approxContour, CvInvoke.ArcLength(contours[i], true) * 0.05, true);

          if (CvInvoke.ContourArea(approxContour, false) > minContourArea)
          {
            if (approxContour.Size == 3)
            {
                var points = approxContour.ToArray();
                primitivesImage.Draw(new Triangle2DF(points[0], points[1], points[2]), new Bgr(Color.GreenYellow), 2);
                triangleCount++;
            }
          }
        }
        string text = $"Triangles: {triangleCount}";
        Point textLocation = new Point(10, 30);
        CvInvoke.PutText(primitivesImage, text, textLocation, FontFace.HersheyComplex, 0.7, new MCvScalar(255, 255, 255), 2);

        processedImage = primitivesImage;
        imageBox2.Image = processedImage;
      }
    }

    private bool isRectangle(Point[] points)
    {
      int delta = 10;
      LineSegment2D[] edges = PointCollection.PolyLine(points, true);

      for (int i = 0; i < edges.Length; i++)
      {
        double angle = Math.Abs(edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
        if (angle < 90 - delta || angle > 90 + delta)
        {
          return false;
        }
      }

      return true;
    }

    private void button_find_quadrilaterals_Click(object sender, EventArgs e)
    {
      if (regionsImage != null)
      {
        VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
        CvInvoke.FindContours(regionsImage.Convert<Gray, byte>(), contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

        int rectCount = 0;
        var primitivesImage = sourceImage.CopyBlank();

        for (int i = 0; i < contours.Size; i++)
        {
          var approxContour = new VectorOfPoint();
          CvInvoke.ApproxPolyDP(contours[i], approxContour, CvInvoke.ArcLength(contours[i], true) * 0.05, true);

          if (CvInvoke.ContourArea(approxContour, false) > minContourArea)
          {
            if (approxContour.Size == 4 && isRectangle(approxContour.ToArray()))
            {
              primitivesImage.Draw(CvInvoke.MinAreaRect(approxContour), new Bgr(Color.GreenYellow), 2);
              rectCount ++;
            }
          }
        }

        string text = $"Rectangles: {rectCount}";
        Point textLocation = new Point(10, 30);
        CvInvoke.PutText(primitivesImage, text, textLocation, FontFace.HersheyComplex, 0.7, new MCvScalar(255, 255, 255), 2);

        processedImage = primitivesImage;
        imageBox2.Image = processedImage;
      }
    }

    private void numericUpDownThreshold_ValueChanged(object sender, EventArgs e)
    {
      thresholdValue = (double)numericUpDownThreshold.Value;
    }

    private void numericUpDownMinArea_ValueChanged(object sender, EventArgs e)
    {
      minContourArea = (double)numericUpDownMinArea.Value;
    }

  }
}
