namespace UnitConverter
{
    partial class LengthConverter
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
            this.inputValueLen = new System.Windows.Forms.TextBox();
            this.lengthTo = new System.Windows.Forms.ComboBox();
            this.lengthFrom = new System.Windows.Forms.ComboBox();
            this.calculateButtonLen = new System.Windows.Forms.Button();
            this.convertLabelLen = new System.Windows.Forms.Label();
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
            // inputValueLen
            // 
            this.inputValueLen.Location = new System.Drawing.Point(150, 171);
            this.inputValueLen.Name = "inputValueLen";
            this.inputValueLen.Size = new System.Drawing.Size(151, 27);
            this.inputValueLen.TabIndex = 43;
            // 
            // lengthTo
            // 
            this.lengthTo.FormattingEnabled = true;
            this.lengthTo.Location = new System.Drawing.Point(150, 119);
            this.lengthTo.Name = "lengthTo";
            this.lengthTo.Size = new System.Drawing.Size(151, 28);
            this.lengthTo.TabIndex = 42;
            // 
            // lengthFrom
            // 
            this.lengthFrom.FormattingEnabled = true;
            this.lengthFrom.Location = new System.Drawing.Point(150, 72);
            this.lengthFrom.Name = "lengthFrom";
            this.lengthFrom.Size = new System.Drawing.Size(151, 28);
            this.lengthFrom.TabIndex = 41;
            // 
            // calculateButtonLen
            // 
            this.calculateButtonLen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButtonLen.Location = new System.Drawing.Point(150, 228);
            this.calculateButtonLen.Name = "calculateButtonLen";
            this.calculateButtonLen.Size = new System.Drawing.Size(101, 38);
            this.calculateButtonLen.TabIndex = 40;
            this.calculateButtonLen.Text = "Calculate";
            this.calculateButtonLen.UseVisualStyleBackColor = true;
            this.calculateButtonLen.Click += new System.EventHandler(this.calculateButtonLen_Click);
            // 
            // convertLabelLen
            // 
            this.convertLabelLen.AutoSize = true;
            this.convertLabelLen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.convertLabelLen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.convertLabelLen.Location = new System.Drawing.Point(150, 290);
            this.convertLabelLen.Name = "convertLabelLen";
            this.convertLabelLen.Size = new System.Drawing.Size(0, 28);
            this.convertLabelLen.TabIndex = 39;
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
            // LengthConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(376, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputValueLen);
            this.Controls.Add(this.lengthTo);
            this.Controls.Add(this.lengthFrom);
            this.Controls.Add(this.calculateButtonLen);
            this.Controls.Add(this.convertLabelLen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LengthConverter";
            this.Text = "LengthConverter";
            this.Load += new System.EventHandler(this.LengthConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputValueLen;
        private System.Windows.Forms.ComboBox lengthTo;
        private System.Windows.Forms.ComboBox lengthFrom;
        private System.Windows.Forms.Button calculateButtonLen;
        private System.Windows.Forms.Label convertLabelLen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}