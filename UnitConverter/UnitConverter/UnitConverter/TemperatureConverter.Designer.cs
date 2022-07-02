namespace UnitConverter
{
    partial class TemperatureConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.inputValueTemp = new System.Windows.Forms.TextBox();
            this.temperatureTo = new System.Windows.Forms.ComboBox();
            this.temperatureFrom = new System.Windows.Forms.ComboBox();
            this.calculateButtonTemp = new System.Windows.Forms.Button();
            this.convertLabelTemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(59, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total:";
            // 
            // inputValueTemp
            // 
            this.inputValueTemp.Location = new System.Drawing.Point(150, 171);
            this.inputValueTemp.Name = "inputValueTemp";
            this.inputValueTemp.Size = new System.Drawing.Size(151, 27);
            this.inputValueTemp.TabIndex = 25;
            // 
            // temperatureTo
            // 
            this.temperatureTo.FormattingEnabled = true;
            this.temperatureTo.Location = new System.Drawing.Point(150, 119);
            this.temperatureTo.Name = "temperatureTo";
            this.temperatureTo.Size = new System.Drawing.Size(151, 28);
            this.temperatureTo.TabIndex = 24;
            // 
            // temperatureFrom
            // 
            this.temperatureFrom.FormattingEnabled = true;
            this.temperatureFrom.Location = new System.Drawing.Point(150, 72);
            this.temperatureFrom.Name = "temperatureFrom";
            this.temperatureFrom.Size = new System.Drawing.Size(151, 28);
            this.temperatureFrom.TabIndex = 23;
            // 
            // calculateButtonTemp
            // 
            this.calculateButtonTemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButtonTemp.Location = new System.Drawing.Point(150, 228);
            this.calculateButtonTemp.Name = "calculateButtonTemp";
            this.calculateButtonTemp.Size = new System.Drawing.Size(101, 38);
            this.calculateButtonTemp.TabIndex = 22;
            this.calculateButtonTemp.Text = "Calculate";
            this.calculateButtonTemp.UseVisualStyleBackColor = true;
            this.calculateButtonTemp.Click += new System.EventHandler(this.calculateButtonTemp_Click);
            // 
            // convertLabelTemp
            // 
            this.convertLabelTemp.AutoSize = true;
            this.convertLabelTemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.convertLabelTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.convertLabelTemp.Location = new System.Drawing.Point(150, 290);
            this.convertLabelTemp.Name = "convertLabelTemp";
            this.convertLabelTemp.Size = new System.Drawing.Size(0, 28);
            this.convertLabelTemp.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(59, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(59, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Value";
            // 
            // TemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(376, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputValueTemp);
            this.Controls.Add(this.temperatureTo);
            this.Controls.Add(this.temperatureFrom);
            this.Controls.Add(this.calculateButtonTemp);
            this.Controls.Add(this.convertLabelTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TemperatureConverter";
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.CurrencyConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputValueTemp;
        private System.Windows.Forms.ComboBox temperatureTo;
        private System.Windows.Forms.ComboBox temperatureFrom;
        private System.Windows.Forms.Button calculateButtonTemp;
        private System.Windows.Forms.Label convertLabelTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}