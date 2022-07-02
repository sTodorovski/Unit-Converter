namespace UnitConverter
{
    partial class TimeConverter
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
            this.inputValueTime = new System.Windows.Forms.TextBox();
            this.timeTo = new System.Windows.Forms.ComboBox();
            this.timeFrom = new System.Windows.Forms.ComboBox();
            this.calculateButtonTime = new System.Windows.Forms.Button();
            this.convertLabelTime = new System.Windows.Forms.Label();
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
            this.label4.TabIndex = 44;
            this.label4.Text = "Total:";
            // 
            // inputValueTime
            // 
            this.inputValueTime.Location = new System.Drawing.Point(150, 171);
            this.inputValueTime.Name = "inputValueTime";
            this.inputValueTime.Size = new System.Drawing.Size(151, 27);
            this.inputValueTime.TabIndex = 43;
            // 
            // timeTo
            // 
            this.timeTo.FormattingEnabled = true;
            this.timeTo.Location = new System.Drawing.Point(150, 119);
            this.timeTo.Name = "timeTo";
            this.timeTo.Size = new System.Drawing.Size(151, 28);
            this.timeTo.TabIndex = 42;
            // 
            // timeFrom
            // 
            this.timeFrom.FormattingEnabled = true;
            this.timeFrom.Location = new System.Drawing.Point(150, 72);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.Size = new System.Drawing.Size(151, 28);
            this.timeFrom.TabIndex = 41;
            // 
            // calculateButtonTime
            // 
            this.calculateButtonTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButtonTime.Location = new System.Drawing.Point(150, 228);
            this.calculateButtonTime.Name = "calculateButtonTime";
            this.calculateButtonTime.Size = new System.Drawing.Size(101, 38);
            this.calculateButtonTime.TabIndex = 40;
            this.calculateButtonTime.Text = "Calculate";
            this.calculateButtonTime.UseVisualStyleBackColor = true;
            this.calculateButtonTime.Click += new System.EventHandler(this.calculateButtonTime_Click);
            // 
            // convertLabelTime
            // 
            this.convertLabelTime.AutoSize = true;
            this.convertLabelTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.convertLabelTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.convertLabelTime.Location = new System.Drawing.Point(150, 290);
            this.convertLabelTime.Name = "convertLabelTime";
            this.convertLabelTime.Size = new System.Drawing.Size(0, 28);
            this.convertLabelTime.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(59, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 28);
            this.label3.TabIndex = 38;
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
            this.label2.TabIndex = 37;
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
            this.label1.TabIndex = 36;
            this.label1.Text = "Value";
            // 
            // TimeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(376, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputValueTime);
            this.Controls.Add(this.timeTo);
            this.Controls.Add(this.timeFrom);
            this.Controls.Add(this.calculateButtonTime);
            this.Controls.Add(this.convertLabelTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TimeConverter";
            this.Text = "TimeConverter";
            this.Load += new System.EventHandler(this.TimeConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputValueTime;
        private System.Windows.Forms.ComboBox timeTo;
        private System.Windows.Forms.ComboBox timeFrom;
        private System.Windows.Forms.Button calculateButtonTime;
        private System.Windows.Forms.Label convertLabelTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}