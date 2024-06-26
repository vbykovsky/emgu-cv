﻿using System.Windows.Forms;

namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.imageBox1 = new Emgu.CV.UI.ImageBox();
      this.openFileDialog = new System.Windows.Forms.Button();
      this.imageBox2 = new Emgu.CV.UI.ImageBox();
      this.button_open_video = new System.Windows.Forms.Button();
      this.button_stop_video = new System.Windows.Forms.Button();
      this.imageBox3 = new Emgu.CV.UI.ImageBox();
      this.imageBox4 = new Emgu.CV.UI.ImageBox();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.trackBar2 = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.button_open_video_file = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
      this.SuspendLayout();
      // 
      // imageBox1
      // 
      this.imageBox1.BackColor = System.Drawing.SystemColors.Control;
      this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.imageBox1.ErrorImage = null;
      this.imageBox1.InitialImage = null;
      this.imageBox1.Location = new System.Drawing.Point(12, 55);
      this.imageBox1.Name = "imageBox1";
      this.imageBox1.Size = new System.Drawing.Size(400, 250);
      this.imageBox1.TabIndex = 2;
      this.imageBox1.TabStop = false;
      // 
      // openFileDialog
      // 
      this.openFileDialog.Location = new System.Drawing.Point(12, 12);
      this.openFileDialog.Name = "openFileDialog";
      this.openFileDialog.Size = new System.Drawing.Size(80, 25);
      this.openFileDialog.TabIndex = 3;
      this.openFileDialog.Text = "Open Photo";
      this.openFileDialog.UseVisualStyleBackColor = true;
      this.openFileDialog.Click += new System.EventHandler(this.button1_Click);
      // 
      // imageBox2
      // 
      this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.imageBox2.Location = new System.Drawing.Point(12, 366);
      this.imageBox2.Name = "imageBox2";
      this.imageBox2.Size = new System.Drawing.Size(400, 250);
      this.imageBox2.TabIndex = 2;
      this.imageBox2.TabStop = false;
      // 
      // button_open_video
      // 
      this.button_open_video.Location = new System.Drawing.Point(12, 322);
      this.button_open_video.Name = "button_open_video";
      this.button_open_video.Size = new System.Drawing.Size(105, 25);
      this.button_open_video.TabIndex = 5;
      this.button_open_video.Text = "Capture WEB Cam";
      this.button_open_video.UseVisualStyleBackColor = true;
      this.button_open_video.Click += new System.EventHandler(this.button_open_video_Click);
      // 
      // button_stop_video
      // 
      this.button_stop_video.Location = new System.Drawing.Point(209, 322);
      this.button_stop_video.Name = "button_stop_video";
      this.button_stop_video.Size = new System.Drawing.Size(55, 25);
      this.button_stop_video.TabIndex = 6;
      this.button_stop_video.Text = "Stop";
      this.button_stop_video.UseVisualStyleBackColor = true;
      this.button_stop_video.Click += new System.EventHandler(this.button_stop_video_Click);
      // 
      // imageBox3
      // 
      this.imageBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.imageBox3.Location = new System.Drawing.Point(429, 55);
      this.imageBox3.Name = "imageBox3";
      this.imageBox3.Size = new System.Drawing.Size(400, 250);
      this.imageBox3.TabIndex = 2;
      this.imageBox3.TabStop = false;
      // 
      // imageBox4
      // 
      this.imageBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.imageBox4.Location = new System.Drawing.Point(429, 366);
      this.imageBox4.Name = "imageBox4";
      this.imageBox4.Size = new System.Drawing.Size(400, 250);
      this.imageBox4.TabIndex = 2;
      this.imageBox4.TabStop = false;
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(12, 644);
      this.trackBar1.Maximum = 100;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(214, 45);
      this.trackBar1.TabIndex = 7;
      this.trackBar1.Value = 100;
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(201, 628);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(25, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "100";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 628);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "cannyThreshold";
      // 
      // trackBar2
      // 
      this.trackBar2.Location = new System.Drawing.Point(242, 644);
      this.trackBar2.Maximum = 100;
      this.trackBar2.Name = "trackBar2";
      this.trackBar2.Size = new System.Drawing.Size(214, 45);
      this.trackBar2.TabIndex = 10;
      this.trackBar2.Value = 100;
      this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(431, 628);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(25, 13);
      this.label3.TabIndex = 11;
      this.label3.Text = "100";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(239, 628);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(117, 13);
      this.label4.TabIndex = 12;
      this.label4.Text = "cannyThresholdLinking";
      // 
      // button_open_video_file
      // 
      this.button_open_video_file.Location = new System.Drawing.Point(123, 322);
      this.button_open_video_file.Name = "button_open_video_file";
      this.button_open_video_file.Size = new System.Drawing.Size(80, 25);
      this.button_open_video_file.TabIndex = 13;
      this.button_open_video_file.Text = "Open Video";
      this.button_open_video_file.UseVisualStyleBackColor = true;
      this.button_open_video_file.Click += new System.EventHandler(this.button_open_video_file_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 39);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(44, 13);
      this.label5.TabIndex = 14;
      this.label5.Text = "Source:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(426, 39);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(40, 13);
      this.label6.TabIndex = 15;
      this.label6.Text = "Result:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(12, 350);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(141, 13);
      this.label7.TabIndex = 16;
      this.label7.Text = "WEB Camera/Video source:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(426, 350);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(40, 13);
      this.label8.TabIndex = 17;
      this.label8.Text = "Result:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(855, 701);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.button_open_video_file);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.trackBar2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.imageBox4);
      this.Controls.Add(this.imageBox3);
      this.Controls.Add(this.button_stop_video);
      this.Controls.Add(this.button_open_video);
      this.Controls.Add(this.imageBox2);
      this.Controls.Add(this.openFileDialog);
      this.Controls.Add(this.imageBox1);
      this.Name = "Form1";
      this.Text = "Lab1";
      ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button openFileDialog;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Button button_open_video;
        private Button button_stop_video;
        private Emgu.CV.UI.ImageBox imageBox3;
        private Emgu.CV.UI.ImageBox imageBox4;
        private TrackBar trackBar1;
        private Label label1;
        private Label label2;
        private TrackBar trackBar2;
        private Label label3;
        private Label label4;
        private Button button_open_video_file;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
  }

}

