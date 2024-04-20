using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace lab3
{
  public partial class Form1 : Form
  {
    private Image<Bgr, byte> sourceImage;
    private Image<Bgr, byte> sourceImageTemp;
    private Image<Bgr, byte> processedImage;
    private PointF[] srcPoints;
    private int pointsSelected = 0;


    public Form1()
    {
      InitializeComponent();
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

          imageBox1.Image = sourceImage;
          srcPoints = null;
          pointsSelected = 0;
      }
    }

    private void button_scale_Click(object sender, EventArgs e)
    {
      if (sourceImage == null)
      {
        MessageBox.Show("There is no image. Open it first!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      float sX = (float)numericUpDown_width.Value;
      float sY = (float)numericUpDown_height.Value;

      if (sX <= 0 || sX <= 0)
      {
        MessageBox.Show("Incorrect scale values!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      processedImage = Filters.ApplyScale(sourceImage, sX, sY);
      imageBox2.Image = processedImage;
    }

    private void button_process_Click(object sender, EventArgs e)
    {
      if (sourceImage == null)
      {
        MessageBox.Show("There is no image. Open it first!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (!float.TryParse(textBox_shift.Text, out float shift))
      {
        MessageBox.Show("Incorrect shift value!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      processedImage = Filters.ApplyShift(sourceImage, shift);
      imageBox2.Image = processedImage;
    }

    private void button_process_image_Click(object sender, EventArgs e)
    {
      if (sourceImage == null)
      {
        MessageBox.Show("There is no image. Open it first!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (!double.TryParse(textBox_angle.Text, out double angle))
      {
        MessageBox.Show("Incorrect angle value!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (!int.TryParse(textBox_centerX.Text, out int centerX) || !int.TryParse(textBox_centerY.Text, out int centerY))
      {
        MessageBox.Show("Incorrect coordinates of center value!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      processedImage = Filters.ApplyRotation(sourceImage, angle, centerX, centerY);
      imageBox2.Image = processedImage;
    }

    private void button_mirror_Click(object sender, EventArgs e)
    {
      if (sourceImage == null)
      {
        MessageBox.Show("There is no image. Open it first!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      processedImage = Filters.ApplyMirror(sourceImage);
      imageBox2.Image = processedImage;
    }

    private void button_projection_Click(object sender, EventArgs e)
    {
      if (sourceImage == null)
      {
        MessageBox.Show("There is no image. Open it first!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (srcPoints == null || srcPoints.Length != 4)
      {
        MessageBox.Show("Choose 4 points on image before projection!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      imageBox2.Image = Filters.ApplyProjection(sourceImage, srcPoints);
    }

    private void imageBox1_MouseClick(object sender, MouseEventArgs e)
    {
      int x = (int)(e.Location.X / imageBox1.ZoomScale);
      int y = (int)(e.Location.Y / imageBox1.ZoomScale);

      Point center = new Point(x, y);
      int radius = 2;
      int thickness = 2;
      var color = new Bgr(Color.Blue).MCvScalar;

      if (sourceImageTemp == null)
      {
        sourceImageTemp = sourceImage.Copy();
      }

      CvInvoke.Circle(sourceImageTemp, center, radius, color, thickness);
      imageBox1.Image = sourceImageTemp;

      if (srcPoints == null)
      {
        srcPoints = new PointF[4];
      }

      srcPoints[pointsSelected] = new PointF(x, y);
      pointsSelected++;

      if (pointsSelected == 4)
      {
        imageBox2.Image = Filters.ApplyProjection(sourceImage, srcPoints);
      }
    }
  }
}
