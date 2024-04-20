namespace lab4
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
      this.imageBox2 = new Emgu.CV.UI.ImageBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button_remove_noise = new System.Windows.Forms.Button();
      this.button_detect_regions = new System.Windows.Forms.Button();
      this.button_find_contours = new System.Windows.Forms.Button();
      this.button_find_primitives = new System.Windows.Forms.Button();
      this.button_find_quadrilaterals = new System.Windows.Forms.Button();
      this.numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownMinArea = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinArea)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // imageBox1
      // 
      this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.imageBox1.Location = new System.Drawing.Point(12, 58);
      this.imageBox1.Name = "imageBox1";
      this.imageBox1.Size = new System.Drawing.Size(450, 300);
      this.imageBox1.TabIndex = 2;
      this.imageBox1.TabStop = false;
      // 
      // imageBox2
      // 
      this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.imageBox2.Location = new System.Drawing.Point(496, 58);
      this.imageBox2.Name = "imageBox2";
      this.imageBox2.Size = new System.Drawing.Size(450, 300);
      this.imageBox2.TabIndex = 2;
      this.imageBox2.TabStop = false;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "Open Image";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button_open_image_Click);
      // 
      // button_remove_noise
      // 
      this.button_remove_noise.Location = new System.Drawing.Point(15, 19);
      this.button_remove_noise.Name = "button_remove_noise";
      this.button_remove_noise.Size = new System.Drawing.Size(98, 23);
      this.button_remove_noise.TabIndex = 4;
      this.button_remove_noise.Text = "Remove Noise";
      this.button_remove_noise.UseVisualStyleBackColor = true;
      this.button_remove_noise.Click += new System.EventHandler(this.button_remove_noise_Click);
      // 
      // button_detect_regions
      // 
      this.button_detect_regions.Location = new System.Drawing.Point(15, 48);
      this.button_detect_regions.Name = "button_detect_regions";
      this.button_detect_regions.Size = new System.Drawing.Size(98, 23);
      this.button_detect_regions.TabIndex = 5;
      this.button_detect_regions.Text = "Detect Regions";
      this.button_detect_regions.UseVisualStyleBackColor = true;
      this.button_detect_regions.Click += new System.EventHandler(this.button_detect_regions_Click);
      // 
      // button_find_contours
      // 
      this.button_find_contours.Location = new System.Drawing.Point(6, 19);
      this.button_find_contours.Name = "button_find_contours";
      this.button_find_contours.Size = new System.Drawing.Size(75, 23);
      this.button_find_contours.TabIndex = 6;
      this.button_find_contours.Text = "Show";
      this.button_find_contours.UseVisualStyleBackColor = true;
      this.button_find_contours.Click += new System.EventHandler(this.button_find_contours_Click);
      // 
      // button_find_primitives
      // 
      this.button_find_primitives.Location = new System.Drawing.Point(6, 18);
      this.button_find_primitives.Name = "button_find_primitives";
      this.button_find_primitives.Size = new System.Drawing.Size(104, 23);
      this.button_find_primitives.TabIndex = 7;
      this.button_find_primitives.Text = "Show Triangles";
      this.button_find_primitives.UseVisualStyleBackColor = true;
      this.button_find_primitives.Click += new System.EventHandler(this.button_find_primitives_Click);
      // 
      // button_find_quadrilaterals
      // 
      this.button_find_quadrilaterals.Location = new System.Drawing.Point(6, 47);
      this.button_find_quadrilaterals.Name = "button_find_quadrilaterals";
      this.button_find_quadrilaterals.Size = new System.Drawing.Size(104, 23);
      this.button_find_quadrilaterals.TabIndex = 8;
      this.button_find_quadrilaterals.Text = "Show Rectangles";
      this.button_find_quadrilaterals.UseVisualStyleBackColor = true;
      this.button_find_quadrilaterals.Click += new System.EventHandler(this.button_find_quadrilaterals_Click);
      // 
      // numericUpDownThreshold
      // 
      this.numericUpDownThreshold.Location = new System.Drawing.Point(9, 32);
      this.numericUpDownThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numericUpDownThreshold.Name = "numericUpDownThreshold";
      this.numericUpDownThreshold.Size = new System.Drawing.Size(88, 20);
      this.numericUpDownThreshold.TabIndex = 9;
      this.numericUpDownThreshold.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
      this.numericUpDownThreshold.ValueChanged += new System.EventHandler(this.numericUpDownThreshold_ValueChanged);
      // 
      // numericUpDownMinArea
      // 
      this.numericUpDownMinArea.Location = new System.Drawing.Point(9, 71);
      this.numericUpDownMinArea.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numericUpDownMinArea.Name = "numericUpDownMinArea";
      this.numericUpDownMinArea.Size = new System.Drawing.Size(88, 20);
      this.numericUpDownMinArea.TabIndex = 10;
      this.numericUpDownMinArea.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
      this.numericUpDownMinArea.ValueChanged += new System.EventHandler(this.numericUpDownMinArea_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 42);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Source:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(493, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 13);
      this.label2.TabIndex = 12;
      this.label2.Text = "Result:";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button_remove_noise);
      this.groupBox1.Controls.Add(this.button_detect_regions);
      this.groupBox1.Location = new System.Drawing.Point(12, 364);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(129, 79);
      this.groupBox1.TabIndex = 13;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "PreProcess";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.button_find_contours);
      this.groupBox2.Location = new System.Drawing.Point(147, 364);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(90, 48);
      this.groupBox2.TabIndex = 14;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Contours";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.button_find_primitives);
      this.groupBox3.Controls.Add(this.button_find_quadrilaterals);
      this.groupBox3.Location = new System.Drawing.Point(244, 365);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(126, 78);
      this.groupBox3.TabIndex = 15;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Primitives";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.label4);
      this.groupBox4.Controls.Add(this.label3);
      this.groupBox4.Controls.Add(this.numericUpDownThreshold);
      this.groupBox4.Controls.Add(this.numericUpDownMinArea);
      this.groupBox4.Location = new System.Drawing.Point(377, 365);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(110, 103);
      this.groupBox4.TabIndex = 16;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Parameters";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 16);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(48, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Treshold";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 55);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(46, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "MinArea";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(965, 485);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.imageBox2);
      this.Controls.Add(this.imageBox1);
      this.Name = "Form1";
      this.Text = "Lab4";
      ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinArea)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_remove_noise;
        private System.Windows.Forms.Button button_detect_regions;
        private System.Windows.Forms.Button button_find_contours;
        private System.Windows.Forms.Button button_find_primitives;
        private System.Windows.Forms.Button button_find_quadrilaterals;
        private System.Windows.Forms.NumericUpDown numericUpDownThreshold;
        private System.Windows.Forms.NumericUpDown numericUpDownMinArea;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
  }
}

