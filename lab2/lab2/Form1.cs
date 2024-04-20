using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;


namespace lab2
{
  public partial class Form1 : Form
  {
    private Timer updateTimer;
    private Image<Bgr, byte> sourceImage;
    private Image<Bgr, byte> sourceImage2;
    private Image<Hsv, byte> hsvImage;
    private Image<Bgr, byte> filteredImage;
    private Image<Bgr, byte> processedImage;
    private Image<Bgr, byte> originalMaskImage;

    public Form1()
    {
      InitializeComponent();

      updateTimer = new Timer();
      updateTimer.Interval = 500;
      updateTimer.Tick += UpdateTimer_Tick;

      trackBarContrast.Scroll += trackBarContrast_Scroll;
      trackBarBrightness.Scroll += trackBarBrightness_Scroll_1;

      trackBarThreshold.ValueChanged += OnThresholdValueChanged;
    }

    private void button_open_image_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

      var result = openFileDialog.ShowDialog();
      if (result == DialogResult.OK)
      {
        string fileName = openFileDialog.FileName;
        sourceImage = new Image<Bgr, byte>(fileName);

        hsvImage = sourceImage.Convert<Hsv, byte>();

        imageBox1.Image = sourceImage;
        imageBox2.Image = filteredImage;

        comboBox_Channel.SelectedIndexChanged += (obj, args) =>
        {
          int selectedIndex = comboBox_Channel.SelectedIndex;
          imageBox2.Image = sourceImage.Split()[selectedIndex];
        };

        UpdateProcessedImage();
      }
    }

    private void button_grey_Click(object sender, EventArgs e)
    {
      if (sourceImage == null)
      {
        return;
      }

      imageBox2.Image = Filters.ApplyGreyFilter(sourceImage);
    }

    private void button_Sepia_Click(object sender, EventArgs e)
    {
      if (sourceImage == null)
      {
        return;
      }

      imageBox2.Image = Filters.ApplySepiaFilter(sourceImage);
    } 

    private void trackBarBrightness_Scroll_1(object sender, EventArgs e)
    {
      updateTimer.Start();
    }
    private void trackBarContrast_Scroll(object sender, EventArgs e)
    {
      updateTimer.Start();
    }

    private void trackBarBrightnessContrast_Scroll(object sender, EventArgs e)
    {
      UpdateProcessedImage();
    }

    private void UpdateTimer_Tick(object sender, EventArgs e)
    {
      updateTimer.Stop();
      UpdateProcessedImage();
    }

    private void UpdateProcessedImage()
    {
      if (sourceImage == null)
      {
        return;
      }

      processedImage = sourceImage.Clone();

      if (trackBarBrightness.Value != 0 || trackBarContrast.Value != 0)
      {
        processedImage._EqualizeHist();

        double gamma = 1.0 + (trackBarContrast.Value / 100.0);
        processedImage = Filters.ApplyGammaCorrection(processedImage, gamma);

        processedImage = Filters.ApplyBrightness(processedImage, trackBarBrightness.Value);
      }

      imageBox2.Image = processedImage;
    }

    private void button_open_image2_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

      var result = openFileDialog.ShowDialog();
      if (result == DialogResult.OK)
      {
        string fileName = openFileDialog.FileName;
        sourceImage2 = new Image<Bgr, byte>(fileName);
        imageBox2.Image = sourceImage2;
      }
    }

    private void button_complement_Click(object sender, EventArgs e)
    {
      if (sourceImage == null)
      {
        return;
      }

      Image<Bgr, byte> complementedImage = sourceImage.Not();
      imageBox2.Image = complementedImage;
    }

    private void button_xor_Click(object sender, EventArgs e)
    {
      if (sourceImage == null)
      {
        return;
      }

      Image<Bgr, byte> xorImage = sourceImage.Xor(sourceImage2);
      imageBox2.Image = xorImage;
    }

    private void button_intersection_Click(object sender, EventArgs e)
    {
      if (sourceImage == null)
      {
        return;
      }

      Image<Bgr, byte> intersectionImage = sourceImage.And(sourceImage2);
      imageBox2.Image = intersectionImage;
    }

    private void trackBarHue_Scroll(object sender, EventArgs e)
    {
      if (hsvImage == null)
      {
        return;
      }

      imageBox2.Image = Filters.ApplyHSVValue(hsvImage, new Hsv(trackBarHue.Value, trackBarSaturation.Value, trackBarValue.Value));
    }

    private void trackBarSaturation_Scroll(object sender, EventArgs e)
    {
      if (hsvImage == null)
      {
        return;
      }

      imageBox2.Image = Filters.ApplyHSVValue(hsvImage, new Hsv(trackBarHue.Value, trackBarSaturation.Value, trackBarValue.Value));
    }

    private void trackBarValue_Scroll(object sender, EventArgs e)
    {
      if (hsvImage == null)
      {
        return;
      }

      imageBox2.Image = Filters.ApplyHSVValue(hsvImage, new Hsv(trackBarHue.Value, trackBarSaturation.Value, trackBarValue.Value));
    }

    private void button_medianBlur_Click(object sender, EventArgs e)
    {
      if (sourceImage == null)
      {
        return;
      }

      int kernelSize = 10;
      Image<Bgr, byte> medianBlurredImage = Filters.ApplyMedianBlur(sourceImage, kernelSize);
      imageBox2.Image = medianBlurredImage;
    }

    private void buttonApplyFilter_Click(object sender, EventArgs e)
    {
      if (sourceImage == null)
      {
        return;
      }

      float[,] filterMatrix = new float[3, 3];
      filterMatrix[0, 0] = float.Parse(textBox.Text);
      filterMatrix[0, 1] = float.Parse(textBox1.Text);
      filterMatrix[0, 2] = float.Parse(textBox2.Text);
      filterMatrix[1, 0] = float.Parse(textBox3.Text);
      filterMatrix[1, 1] = float.Parse(textBox4.Text);
      filterMatrix[1, 2] = float.Parse(textBox5.Text);
      filterMatrix[2, 0] = float.Parse(textBox6.Text);
      filterMatrix[2, 1] = float.Parse(textBox7.Text);
      filterMatrix[2, 2] = float.Parse(textBox8.Text);

      imageBox2.Image = Filters.ApplyMatrixFilter(sourceImage, filterMatrix);
    }

    private void button_watercolor_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

      var result = openFileDialog.ShowDialog();
      if (result == DialogResult.OK)
      {
        string fileName = openFileDialog.FileName;
        originalMaskImage = new Image<Bgr, byte>(fileName);

        filteredImage = Filters.ApplyWatercolorFilter(sourceImage, originalMaskImage);
        imageBox2.Image = filteredImage;
      }
    }

    private void trackBar_brightness_Scroll(object sender, EventArgs e)
    {
      if (filteredImage == null)
      {
        return;
      }

      imageBox2.Image = Filters.AdjustBrightness(filteredImage, trackBar_brightness.Value);
    }

    private void trackBar_contrast_Scroll(object sender, EventArgs e)
    {
      if (filteredImage == null)
      {
        return;
      }

      imageBox2.Image = Filters.AdjustContrast(filteredImage, trackBar_contrast.Value / 10.0);
    }

    private void trackBar_blend_Scroll(object sender, EventArgs e)
    {
      if (originalMaskImage == null)
      {
        return;
      }

      var blendValue = trackBar_blend.Value / 100.0;
      CvInvoke.AddWeighted(sourceImage, blendValue, originalMaskImage, 1 - blendValue, 0, filteredImage);
      imageBox2.Image = filteredImage;
    }

    private void OnThresholdValueChanged(object sender, EventArgs e)
    {
      if (sourceImage == null)
      {
        return;
      }

      imageBox2.Image = Filters.ApplyCartoonFilter(sourceImage, trackBarThreshold.Value);
    }
  }
}
