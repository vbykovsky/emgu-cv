namespace lab2
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
      this.button_open_image = new System.Windows.Forms.Button();
      this.comboBox_Channel = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button_Sepia = new System.Windows.Forms.Button();
      this.button_grey = new System.Windows.Forms.Button();
      this.trackBarBrightness = new System.Windows.Forms.TrackBar();
      this.label2 = new System.Windows.Forms.Label();
      this.trackBarContrast = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.button_open_image2 = new System.Windows.Forms.Button();
      this.button_complement = new System.Windows.Forms.Button();
      this.button_xor = new System.Windows.Forms.Button();
      this.button_intersection = new System.Windows.Forms.Button();
      this.trackBarHue = new System.Windows.Forms.TrackBar();
      this.trackBarSaturation = new System.Windows.Forms.TrackBar();
      this.trackBarValue = new System.Windows.Forms.TrackBar();
      this.button_medianBlur = new System.Windows.Forms.Button();
      this.buttonApplyFilter = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.textBox7 = new System.Windows.Forms.TextBox();
      this.textBox8 = new System.Windows.Forms.TextBox();
      this.textBox = new System.Windows.Forms.TextBox();
      this.button_watercolor = new System.Windows.Forms.Button();
      this.trackBar_brightness = new System.Windows.Forms.TrackBar();
      this.trackBar_contrast = new System.Windows.Forms.TrackBar();
      this.trackBar_blend = new System.Windows.Forms.TrackBar();
      this.trackBarThreshold = new System.Windows.Forms.TrackBar();
      this.Brightness = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarValue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_brightness)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_contrast)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_blend)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.SuspendLayout();
      // 
      // imageBox1
      // 
      this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.imageBox1.Location = new System.Drawing.Point(23, 71);
      this.imageBox1.Name = "imageBox1";
      this.imageBox1.Size = new System.Drawing.Size(450, 300);
      this.imageBox1.TabIndex = 2;
      this.imageBox1.TabStop = false;
      // 
      // imageBox2
      // 
      this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.imageBox2.Location = new System.Drawing.Point(519, 71);
      this.imageBox2.Name = "imageBox2";
      this.imageBox2.Size = new System.Drawing.Size(450, 300);
      this.imageBox2.TabIndex = 2;
      this.imageBox2.TabStop = false;
      // 
      // button_open_image
      // 
      this.button_open_image.Location = new System.Drawing.Point(23, 21);
      this.button_open_image.Name = "button_open_image";
      this.button_open_image.Size = new System.Drawing.Size(100, 30);
      this.button_open_image.TabIndex = 3;
      this.button_open_image.Text = "Open Image";
      this.button_open_image.UseVisualStyleBackColor = true;
      this.button_open_image.Click += new System.EventHandler(this.button_open_image_Click);
      // 
      // comboBox_Channel
      // 
      this.comboBox_Channel.FormattingEnabled = true;
      this.comboBox_Channel.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
      this.comboBox_Channel.Location = new System.Drawing.Point(522, 27);
      this.comboBox_Channel.Name = "comboBox_Channel";
      this.comboBox_Channel.Size = new System.Drawing.Size(86, 21);
      this.comboBox_Channel.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(522, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Color channel";
      // 
      // button_Sepia
      // 
      this.button_Sepia.Location = new System.Drawing.Point(729, 21);
      this.button_Sepia.Name = "button_Sepia";
      this.button_Sepia.Size = new System.Drawing.Size(100, 30);
      this.button_Sepia.TabIndex = 6;
      this.button_Sepia.Text = "Sepia";
      this.button_Sepia.UseVisualStyleBackColor = true;
      this.button_Sepia.Click += new System.EventHandler(this.button_Sepia_Click);
      // 
      // button_grey
      // 
      this.button_grey.Location = new System.Drawing.Point(623, 21);
      this.button_grey.Name = "button_grey";
      this.button_grey.Size = new System.Drawing.Size(100, 30);
      this.button_grey.TabIndex = 7;
      this.button_grey.Text = "Grey";
      this.button_grey.UseVisualStyleBackColor = true;
      this.button_grey.Click += new System.EventHandler(this.button_grey_Click);
      // 
      // trackBarBrightness
      // 
      this.trackBarBrightness.Location = new System.Drawing.Point(18, 38);
      this.trackBarBrightness.Maximum = 100;
      this.trackBarBrightness.Minimum = -100;
      this.trackBarBrightness.Name = "trackBarBrightness";
      this.trackBarBrightness.Size = new System.Drawing.Size(104, 45);
      this.trackBarBrightness.TabIndex = 8;
      this.trackBarBrightness.Value = 100;
      this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll_1);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 22);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Brightness";
      // 
      // trackBarContrast
      // 
      this.trackBarContrast.Location = new System.Drawing.Point(18, 99);
      this.trackBarContrast.Maximum = 100;
      this.trackBarContrast.Minimum = -100;
      this.trackBarContrast.Name = "trackBarContrast";
      this.trackBarContrast.Size = new System.Drawing.Size(104, 45);
      this.trackBarContrast.TabIndex = 10;
      this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 84);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 13);
      this.label3.TabIndex = 11;
      this.label3.Text = "Contrast";
      // 
      // button_open_image2
      // 
      this.button_open_image2.Location = new System.Drawing.Point(21, 19);
      this.button_open_image2.Name = "button_open_image2";
      this.button_open_image2.Size = new System.Drawing.Size(90, 23);
      this.button_open_image2.TabIndex = 12;
      this.button_open_image2.Text = "Open image";
      this.button_open_image2.UseVisualStyleBackColor = true;
      this.button_open_image2.Click += new System.EventHandler(this.button_open_image2_Click);
      // 
      // button_complement
      // 
      this.button_complement.Location = new System.Drawing.Point(21, 48);
      this.button_complement.Name = "button_complement";
      this.button_complement.Size = new System.Drawing.Size(90, 23);
      this.button_complement.TabIndex = 13;
      this.button_complement.Text = "NOT";
      this.button_complement.UseVisualStyleBackColor = true;
      this.button_complement.Click += new System.EventHandler(this.button_complement_Click);
      // 
      // button_xor
      // 
      this.button_xor.Location = new System.Drawing.Point(21, 78);
      this.button_xor.Name = "button_xor";
      this.button_xor.Size = new System.Drawing.Size(90, 23);
      this.button_xor.TabIndex = 14;
      this.button_xor.Text = "XOR";
      this.button_xor.UseVisualStyleBackColor = true;
      this.button_xor.Click += new System.EventHandler(this.button_xor_Click);
      // 
      // button_intersection
      // 
      this.button_intersection.Location = new System.Drawing.Point(21, 108);
      this.button_intersection.Name = "button_intersection";
      this.button_intersection.Size = new System.Drawing.Size(90, 23);
      this.button_intersection.TabIndex = 15;
      this.button_intersection.Text = "AND";
      this.button_intersection.UseVisualStyleBackColor = true;
      this.button_intersection.Click += new System.EventHandler(this.button_intersection_Click);
      // 
      // trackBarHue
      // 
      this.trackBarHue.Location = new System.Drawing.Point(14, 38);
      this.trackBarHue.Maximum = 255;
      this.trackBarHue.Name = "trackBarHue";
      this.trackBarHue.Size = new System.Drawing.Size(104, 45);
      this.trackBarHue.TabIndex = 16;
      this.trackBarHue.Scroll += new System.EventHandler(this.trackBarHue_Scroll);
      // 
      // trackBarSaturation
      // 
      this.trackBarSaturation.Location = new System.Drawing.Point(14, 98);
      this.trackBarSaturation.Maximum = 255;
      this.trackBarSaturation.Name = "trackBarSaturation";
      this.trackBarSaturation.Size = new System.Drawing.Size(104, 45);
      this.trackBarSaturation.TabIndex = 17;
      this.trackBarSaturation.Scroll += new System.EventHandler(this.trackBarSaturation_Scroll);
      // 
      // trackBarValue
      // 
      this.trackBarValue.Location = new System.Drawing.Point(14, 155);
      this.trackBarValue.Maximum = 255;
      this.trackBarValue.Name = "trackBarValue";
      this.trackBarValue.Size = new System.Drawing.Size(104, 45);
      this.trackBarValue.TabIndex = 18;
      this.trackBarValue.Scroll += new System.EventHandler(this.trackBarValue_Scroll);
      // 
      // button_medianBlur
      // 
      this.button_medianBlur.Location = new System.Drawing.Point(835, 21);
      this.button_medianBlur.Name = "button_medianBlur";
      this.button_medianBlur.Size = new System.Drawing.Size(100, 30);
      this.button_medianBlur.TabIndex = 19;
      this.button_medianBlur.Text = "Blur";
      this.button_medianBlur.UseVisualStyleBackColor = true;
      this.button_medianBlur.Click += new System.EventHandler(this.button_medianBlur_Click);
      // 
      // buttonApplyFilter
      // 
      this.buttonApplyFilter.Location = new System.Drawing.Point(17, 108);
      this.buttonApplyFilter.Name = "buttonApplyFilter";
      this.buttonApplyFilter.Size = new System.Drawing.Size(80, 23);
      this.buttonApplyFilter.TabIndex = 33;
      this.buttonApplyFilter.Text = "Apply";
      this.buttonApplyFilter.UseVisualStyleBackColor = true;
      this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(44, 21);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(23, 20);
      this.textBox1.TabIndex = 34;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(73, 21);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(23, 20);
      this.textBox2.TabIndex = 35;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(17, 48);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(23, 20);
      this.textBox3.TabIndex = 36;
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(44, 48);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(25, 20);
      this.textBox4.TabIndex = 37;
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(73, 48);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(24, 20);
      this.textBox5.TabIndex = 38;
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(17, 74);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(23, 20);
      this.textBox6.TabIndex = 39;
      // 
      // textBox7
      // 
      this.textBox7.Location = new System.Drawing.Point(44, 74);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new System.Drawing.Size(25, 20);
      this.textBox7.TabIndex = 40;
      // 
      // textBox8
      // 
      this.textBox8.Location = new System.Drawing.Point(73, 74);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new System.Drawing.Size(24, 20);
      this.textBox8.TabIndex = 41;
      // 
      // textBox
      // 
      this.textBox.Location = new System.Drawing.Point(17, 21);
      this.textBox.Name = "textBox";
      this.textBox.Size = new System.Drawing.Size(23, 20);
      this.textBox.TabIndex = 43;
      // 
      // button_watercolor
      // 
      this.button_watercolor.Location = new System.Drawing.Point(18, 21);
      this.button_watercolor.Name = "button_watercolor";
      this.button_watercolor.Size = new System.Drawing.Size(75, 23);
      this.button_watercolor.TabIndex = 44;
      this.button_watercolor.Text = "Open image";
      this.button_watercolor.UseVisualStyleBackColor = true;
      this.button_watercolor.Click += new System.EventHandler(this.button_watercolor_Click);
      // 
      // trackBar_brightness
      // 
      this.trackBar_brightness.Location = new System.Drawing.Point(18, 69);
      this.trackBar_brightness.Maximum = 50;
      this.trackBar_brightness.Name = "trackBar_brightness";
      this.trackBar_brightness.Size = new System.Drawing.Size(104, 45);
      this.trackBar_brightness.TabIndex = 45;
      this.trackBar_brightness.Scroll += new System.EventHandler(this.trackBar_brightness_Scroll);
      // 
      // trackBar_contrast
      // 
      this.trackBar_contrast.Location = new System.Drawing.Point(18, 129);
      this.trackBar_contrast.Maximum = 50;
      this.trackBar_contrast.Name = "trackBar_contrast";
      this.trackBar_contrast.Size = new System.Drawing.Size(104, 45);
      this.trackBar_contrast.TabIndex = 46;
      this.trackBar_contrast.Scroll += new System.EventHandler(this.trackBar_contrast_Scroll);
      // 
      // trackBar_blend
      // 
      this.trackBar_blend.Location = new System.Drawing.Point(18, 191);
      this.trackBar_blend.Maximum = 100;
      this.trackBar_blend.Name = "trackBar_blend";
      this.trackBar_blend.Size = new System.Drawing.Size(104, 45);
      this.trackBar_blend.TabIndex = 47;
      this.trackBar_blend.Scroll += new System.EventHandler(this.trackBar_blend_Scroll);
      // 
      // trackBarThreshold
      // 
      this.trackBarThreshold.Location = new System.Drawing.Point(16, 19);
      this.trackBarThreshold.Maximum = 200;
      this.trackBarThreshold.Name = "trackBarThreshold";
      this.trackBarThreshold.Size = new System.Drawing.Size(104, 45);
      this.trackBarThreshold.TabIndex = 0;
      // 
      // Brightness
      // 
      this.Brightness.AutoSize = true;
      this.Brightness.Location = new System.Drawing.Point(15, 53);
      this.Brightness.Name = "Brightness";
      this.Brightness.Size = new System.Drawing.Size(56, 13);
      this.Brightness.TabIndex = 48;
      this.Brightness.Text = "Brightness";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(15, 113);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(46, 13);
      this.label4.TabIndex = 49;
      this.label4.Text = "Contrast";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(15, 175);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(34, 13);
      this.label5.TabIndex = 50;
      this.label5.Text = "Blend";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(11, 22);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(27, 13);
      this.label7.TabIndex = 53;
      this.label7.Text = "Hue";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(11, 82);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(55, 13);
      this.label8.TabIndex = 54;
      this.label8.Text = "Saturation";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(11, 139);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(34, 13);
      this.label9.TabIndex = 55;
      this.label9.Text = "Value";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button_open_image2);
      this.groupBox1.Controls.Add(this.button_complement);
      this.groupBox1.Controls.Add(this.button_xor);
      this.groupBox1.Controls.Add(this.button_intersection);
      this.groupBox1.Location = new System.Drawing.Point(23, 401);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(126, 142);
      this.groupBox1.TabIndex = 56;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Operations";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.trackBarHue);
      this.groupBox2.Controls.Add(this.label9);
      this.groupBox2.Controls.Add(this.trackBarSaturation);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.trackBarValue);
      this.groupBox2.Location = new System.Drawing.Point(173, 401);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(134, 210);
      this.groupBox2.TabIndex = 57;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "HSV";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.trackBarBrightness);
      this.groupBox3.Controls.Add(this.label2);
      this.groupBox3.Controls.Add(this.trackBarContrast);
      this.groupBox3.Controls.Add(this.label3);
      this.groupBox3.Location = new System.Drawing.Point(333, 401);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(133, 152);
      this.groupBox3.TabIndex = 58;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "BC";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.textBox);
      this.groupBox4.Controls.Add(this.textBox1);
      this.groupBox4.Controls.Add(this.textBox2);
      this.groupBox4.Controls.Add(this.textBox3);
      this.groupBox4.Controls.Add(this.textBox4);
      this.groupBox4.Controls.Add(this.textBox5);
      this.groupBox4.Controls.Add(this.textBox6);
      this.groupBox4.Controls.Add(this.textBox7);
      this.groupBox4.Controls.Add(this.textBox8);
      this.groupBox4.Controls.Add(this.buttonApplyFilter);
      this.groupBox4.Location = new System.Drawing.Point(491, 401);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(116, 144);
      this.groupBox4.TabIndex = 59;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Matrix Filter";
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.button_watercolor);
      this.groupBox5.Controls.Add(this.Brightness);
      this.groupBox5.Controls.Add(this.trackBar_brightness);
      this.groupBox5.Controls.Add(this.label4);
      this.groupBox5.Controls.Add(this.trackBar_contrast);
      this.groupBox5.Controls.Add(this.label5);
      this.groupBox5.Controls.Add(this.trackBar_blend);
      this.groupBox5.Location = new System.Drawing.Point(630, 401);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(131, 252);
      this.groupBox5.TabIndex = 60;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Watercolor";
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.trackBarThreshold);
      this.groupBox7.Location = new System.Drawing.Point(782, 401);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(137, 66);
      this.groupBox7.TabIndex = 62;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Cartoon";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1006, 674);
      this.Controls.Add(this.groupBox7);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button_medianBlur);
      this.Controls.Add(this.button_grey);
      this.Controls.Add(this.button_Sepia);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.comboBox_Channel);
      this.Controls.Add(this.button_open_image);
      this.Controls.Add(this.imageBox2);
      this.Controls.Add(this.imageBox1);
      this.Name = "Form1";
      this.Text = "Lab2";
      ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarValue)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_brightness)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_contrast)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_blend)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button button_open_image;
        private System.Windows.Forms.ComboBox comboBox_Channel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Sepia;
        private System.Windows.Forms.Button button_grey;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_open_image2;
        private System.Windows.Forms.Button button_complement;
        private System.Windows.Forms.Button button_xor;
        private System.Windows.Forms.Button button_intersection;
        private System.Windows.Forms.TrackBar trackBarHue;
        private System.Windows.Forms.TrackBar trackBarSaturation;
        private System.Windows.Forms.TrackBar trackBarValue;
        private System.Windows.Forms.Button button_medianBlur;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button_watercolor;
        private System.Windows.Forms.TrackBar trackBar_brightness;
        private System.Windows.Forms.TrackBar trackBar_contrast;
        private System.Windows.Forms.TrackBar trackBar_blend;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.Label Brightness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.GroupBox groupBox7;
  }
}

