namespace lab3
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
      this.numericUpDown_width = new System.Windows.Forms.NumericUpDown();
      this.button_scale = new System.Windows.Forms.Button();
      this.numericUpDown_height = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button_process = new System.Windows.Forms.Button();
      this.textBox_shift = new System.Windows.Forms.TextBox();
      this.textBox_angle = new System.Windows.Forms.TextBox();
      this.textBox_centerX = new System.Windows.Forms.TextBox();
      this.textBox_centerY = new System.Windows.Forms.TextBox();
      this.button_process_image = new System.Windows.Forms.Button();
      this.button_mirror = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.button_projection = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox5.SuspendLayout();
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
      this.imageBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseClick);
      // 
      // imageBox2
      // 
      this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.imageBox2.Location = new System.Drawing.Point(494, 58);
      this.imageBox2.Name = "imageBox2";
      this.imageBox2.Size = new System.Drawing.Size(450, 300);
      this.imageBox2.TabIndex = 2;
      this.imageBox2.TabStop = false;
      // 
      // button_open_image
      // 
      this.button_open_image.Location = new System.Drawing.Point(12, 12);
      this.button_open_image.Name = "button_open_image";
      this.button_open_image.Size = new System.Drawing.Size(84, 23);
      this.button_open_image.TabIndex = 3;
      this.button_open_image.Text = "Open image";
      this.button_open_image.UseVisualStyleBackColor = true;
      this.button_open_image.Click += new System.EventHandler(this.button_open_image_Click);
      // 
      // numericUpDown_width
      // 
      this.numericUpDown_width.DecimalPlaces = 1;
      this.numericUpDown_width.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.numericUpDown_width.Location = new System.Drawing.Point(9, 32);
      this.numericUpDown_width.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numericUpDown_width.Name = "numericUpDown_width";
      this.numericUpDown_width.Size = new System.Drawing.Size(100, 20);
      this.numericUpDown_width.TabIndex = 4;
      // 
      // button_scale
      // 
      this.button_scale.Location = new System.Drawing.Point(9, 97);
      this.button_scale.Name = "button_scale";
      this.button_scale.Size = new System.Drawing.Size(100, 23);
      this.button_scale.TabIndex = 5;
      this.button_scale.Text = "Apply";
      this.button_scale.UseVisualStyleBackColor = true;
      this.button_scale.Click += new System.EventHandler(this.button_scale_Click);
      // 
      // numericUpDown_height
      // 
      this.numericUpDown_height.DecimalPlaces = 1;
      this.numericUpDown_height.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.numericUpDown_height.Location = new System.Drawing.Point(9, 71);
      this.numericUpDown_height.Name = "numericUpDown_height";
      this.numericUpDown_height.Size = new System.Drawing.Size(100, 20);
      this.numericUpDown_height.TabIndex = 6;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "Width";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 55);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Height";
      // 
      // button_process
      // 
      this.button_process.Location = new System.Drawing.Point(9, 58);
      this.button_process.Name = "button_process";
      this.button_process.Size = new System.Drawing.Size(100, 23);
      this.button_process.TabIndex = 9;
      this.button_process.Text = "Apply";
      this.button_process.UseVisualStyleBackColor = true;
      this.button_process.Click += new System.EventHandler(this.button_process_Click);
      // 
      // textBox_shift
      // 
      this.textBox_shift.Location = new System.Drawing.Point(9, 32);
      this.textBox_shift.Name = "textBox_shift";
      this.textBox_shift.Size = new System.Drawing.Size(100, 20);
      this.textBox_shift.TabIndex = 10;
      // 
      // textBox_angle
      // 
      this.textBox_angle.Location = new System.Drawing.Point(9, 32);
      this.textBox_angle.Name = "textBox_angle";
      this.textBox_angle.Size = new System.Drawing.Size(100, 20);
      this.textBox_angle.TabIndex = 12;
      // 
      // textBox_centerX
      // 
      this.textBox_centerX.Location = new System.Drawing.Point(9, 71);
      this.textBox_centerX.Name = "textBox_centerX";
      this.textBox_centerX.Size = new System.Drawing.Size(100, 20);
      this.textBox_centerX.TabIndex = 13;
      // 
      // textBox_centerY
      // 
      this.textBox_centerY.Location = new System.Drawing.Point(9, 110);
      this.textBox_centerY.Name = "textBox_centerY";
      this.textBox_centerY.Size = new System.Drawing.Size(100, 20);
      this.textBox_centerY.TabIndex = 14;
      // 
      // button_process_image
      // 
      this.button_process_image.Location = new System.Drawing.Point(9, 136);
      this.button_process_image.Name = "button_process_image";
      this.button_process_image.Size = new System.Drawing.Size(100, 23);
      this.button_process_image.TabIndex = 15;
      this.button_process_image.Text = "Apply";
      this.button_process_image.UseVisualStyleBackColor = true;
      this.button_process_image.Click += new System.EventHandler(this.button_process_image_Click);
      // 
      // button_mirror
      // 
      this.button_mirror.Location = new System.Drawing.Point(6, 19);
      this.button_mirror.Name = "button_mirror";
      this.button_mirror.Size = new System.Drawing.Size(84, 23);
      this.button_mirror.TabIndex = 16;
      this.button_mirror.Text = "Apply";
      this.button_mirror.UseVisualStyleBackColor = true;
      this.button_mirror.Click += new System.EventHandler(this.button_mirror_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 16);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(78, 13);
      this.label3.TabIndex = 17;
      this.label3.Text = "Angle(degrees)";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 55);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(90, 13);
      this.label4.TabIndex = 18;
      this.label4.Text = "Rotation center X";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 94);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(90, 13);
      this.label5.TabIndex = 19;
      this.label5.Text = "Rotation center Y";
      // 
      // button_projection
      // 
      this.button_projection.Location = new System.Drawing.Point(10, 55);
      this.button_projection.Name = "button_projection";
      this.button_projection.Size = new System.Drawing.Size(100, 23);
      this.button_projection.TabIndex = 20;
      this.button_projection.Text = "Apply";
      this.button_projection.UseVisualStyleBackColor = true;
      this.button_projection.Click += new System.EventHandler(this.button_projection_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.numericUpDown_width);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.numericUpDown_height);
      this.groupBox1.Controls.Add(this.button_scale);
      this.groupBox1.Location = new System.Drawing.Point(12, 364);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(122, 127);
      this.groupBox1.TabIndex = 21;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Scaling";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.textBox_shift);
      this.groupBox2.Controls.Add(this.button_process);
      this.groupBox2.Location = new System.Drawing.Point(140, 364);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(120, 91);
      this.groupBox2.TabIndex = 22;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Shearing";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.label3);
      this.groupBox3.Controls.Add(this.textBox_angle);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.textBox_centerX);
      this.groupBox3.Controls.Add(this.label5);
      this.groupBox3.Controls.Add(this.textBox_centerY);
      this.groupBox3.Controls.Add(this.button_process_image);
      this.groupBox3.Location = new System.Drawing.Point(266, 364);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(119, 168);
      this.groupBox3.TabIndex = 23;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Rotation";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.label7);
      this.groupBox4.Controls.Add(this.button_projection);
      this.groupBox4.Location = new System.Drawing.Point(391, 364);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(116, 100);
      this.groupBox4.TabIndex = 24;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Porjection";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(6, 16);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(34, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Value";
      // 
      // label7
      // 
      this.label7.Location = new System.Drawing.Point(7, 16);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(100, 36);
      this.label7.TabIndex = 0;
      this.label7.Text = "Select 4 poins on image before projection";
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.button_mirror);
      this.groupBox5.Location = new System.Drawing.Point(513, 364);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(116, 52);
      this.groupBox5.TabIndex = 25;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Mirroring";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(12, 42);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(44, 13);
      this.label8.TabIndex = 26;
      this.label8.Text = "Source:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(491, 42);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(40, 13);
      this.label9.TabIndex = 27;
      this.label9.Text = "Result:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(957, 605);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button_open_image);
      this.Controls.Add(this.imageBox2);
      this.Controls.Add(this.imageBox1);
      this.Name = "Form1";
      this.Text = "Lab3";
      ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox5.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button button_open_image;
        private System.Windows.Forms.NumericUpDown numericUpDown_width;
        private System.Windows.Forms.Button button_scale;
        private System.Windows.Forms.NumericUpDown numericUpDown_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_process;
        private System.Windows.Forms.TextBox textBox_shift;
        private System.Windows.Forms.TextBox textBox_angle;
        private System.Windows.Forms.TextBox textBox_centerX;
        private System.Windows.Forms.TextBox textBox_centerY;
        private System.Windows.Forms.Button button_process_image;
        private System.Windows.Forms.Button button_mirror;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_projection;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
  }
}

