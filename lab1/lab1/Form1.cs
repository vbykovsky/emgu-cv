using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage;
        private VideoCapture capture;
        private int cannyThreshold = 100;
        private int cannyThresholdLinking = 100;
        private Image<Bgr, byte> image;
        private Image<Gray, byte> cannyEdges;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                sourceImage = new Image<Bgr, byte>(fileName);

                var grayImage = Filters.GetGrayImage(ref sourceImage);
                imageBox3.Image = grayImage;
                imageBox3.SizeMode = PictureBoxSizeMode.Zoom;

                var resultImage = Filters.ApplyToImage(ref sourceImage, cannyThreshold, cannyThresholdLinking);
                imageBox1.SizeMode = PictureBoxSizeMode.Zoom;
                imageBox1.Image = resultImage.Resize(640, 480, Inter.Linear);
            }

        }

        private void button_open_video_Click(object sender, EventArgs e)
        {
            capture = new VideoCapture();
            capture.ImageGrabbed += ProcessFrame;
            capture.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            var frame = new Mat();
            capture.Retrieve(frame);

            if (frame.IsEmpty)
            {
                capture.Stop();
                capture.Dispose();
                imageBox2.Image?.Dispose();
                imageBox4.Image?.Dispose();
                imageBox2.Image = null;
                imageBox4.Image = null;
                return;
            }

            image = frame.ToImage<Bgr, byte>();
            imageBox2.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox2.Image = frame;

            cannyEdges = image.Canny(cannyThreshold, cannyThresholdLinking);
            imageBox4.Image = cannyEdges;
            imageBox4.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void button_stop_video_Click(object sender, EventArgs e)
        {
            capture?.Stop();
            capture?.Dispose();
            imageBox2.Image?.Dispose();
            imageBox2.Image = null;
            imageBox4.Image?.Dispose();
            imageBox4.Image = null;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            cannyThreshold = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar2.Value.ToString();
            cannyThresholdLinking = trackBar2.Value;
        }

        private void button_open_video_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы видео (*.mp4) | *.mp4;";
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                capture = new VideoCapture(fileName);
                capture.ImageGrabbed += ProcessFrame;
                capture.Start();
            }
        }

    }
}
