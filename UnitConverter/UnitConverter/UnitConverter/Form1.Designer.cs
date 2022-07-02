namespace UnitConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toCurrencyConverter = new System.Windows.Forms.Button();
            this.toTemperatureConverter = new System.Windows.Forms.Button();
            this.toLengthConverter = new System.Windows.Forms.Button();
            this.toTimeConverter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // toCurrencyConverter
            // 
            this.toCurrencyConverter.BackColor = System.Drawing.Color.SkyBlue;
            this.toCurrencyConverter.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toCurrencyConverter.Location = new System.Drawing.Point(12, 12);
            this.toCurrencyConverter.Margin = new System.Windows.Forms.Padding(0);
            this.toCurrencyConverter.Name = "toCurrencyConverter";
            this.toCurrencyConverter.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.toCurrencyConverter.Size = new System.Drawing.Size(523, 121);
            this.toCurrencyConverter.TabIndex = 0;
            this.toCurrencyConverter.Text = "Currency Converter";
            this.toCurrencyConverter.UseVisualStyleBackColor = false;
            this.toCurrencyConverter.Click += new System.EventHandler(this.toCurrencyConverter_Click);
            // 
            // toTemperatureConverter
            // 
            this.toTemperatureConverter.BackColor = System.Drawing.Color.DarkOrange;
            this.toTemperatureConverter.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toTemperatureConverter.Location = new System.Drawing.Point(12, 139);
            this.toTemperatureConverter.Margin = new System.Windows.Forms.Padding(0);
            this.toTemperatureConverter.Name = "toTemperatureConverter";
            this.toTemperatureConverter.Padding = new System.Windows.Forms.Padding(118, 0, 0, 0);
            this.toTemperatureConverter.Size = new System.Drawing.Size(523, 121);
            this.toTemperatureConverter.TabIndex = 1;
            this.toTemperatureConverter.Text = "Temperature Converter";
            this.toTemperatureConverter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toTemperatureConverter.UseVisualStyleBackColor = false;
            this.toTemperatureConverter.Click += new System.EventHandler(this.toTemperatureConverter_Click);
            // 
            // toLengthConverter
            // 
            this.toLengthConverter.BackColor = System.Drawing.Color.LightSeaGreen;
            this.toLengthConverter.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toLengthConverter.Location = new System.Drawing.Point(12, 266);
            this.toLengthConverter.Margin = new System.Windows.Forms.Padding(0);
            this.toLengthConverter.Name = "toLengthConverter";
            this.toLengthConverter.Padding = new System.Windows.Forms.Padding(120, 0, 0, 0);
            this.toLengthConverter.Size = new System.Drawing.Size(523, 121);
            this.toLengthConverter.TabIndex = 2;
            this.toLengthConverter.Text = "Length Converter";
            this.toLengthConverter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toLengthConverter.UseVisualStyleBackColor = false;
            this.toLengthConverter.Click += new System.EventHandler(this.toLengthConverter_Click);
            // 
            // toTimeConverter
            // 
            this.toTimeConverter.BackColor = System.Drawing.Color.DarkViolet;
            this.toTimeConverter.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toTimeConverter.Location = new System.Drawing.Point(12, 393);
            this.toTimeConverter.Margin = new System.Windows.Forms.Padding(0);
            this.toTimeConverter.Name = "toTimeConverter";
            this.toTimeConverter.Padding = new System.Windows.Forms.Padding(120, 0, 0, 0);
            this.toTimeConverter.Size = new System.Drawing.Size(523, 121);
            this.toTimeConverter.TabIndex = 3;
            this.toTimeConverter.Text = "Time Converter";
            this.toTimeConverter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toTimeConverter.UseVisualStyleBackColor = false;
            this.toTimeConverter.Click += new System.EventHandler(this.toTimeConverter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(31, 283);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(31, 411);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(547, 526);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toTimeConverter);
            this.Controls.Add(this.toLengthConverter);
            this.Controls.Add(this.toTemperatureConverter);
            this.Controls.Add(this.toCurrencyConverter);
            this.Name = "Form1";
            this.Text = "Unit Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toCurrencyConverter;
        private System.Windows.Forms.Button toTemperatureConverter;
        private System.Windows.Forms.Button toLengthConverter;
        private System.Windows.Forms.Button toTimeConverter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
