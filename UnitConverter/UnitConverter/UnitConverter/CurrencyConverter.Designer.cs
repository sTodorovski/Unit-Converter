namespace UnitConverter
{
    partial class CurrencyConverter
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
            this.inputValueCurr = new System.Windows.Forms.TextBox();
            this.currencyTo = new System.Windows.Forms.ComboBox();
            this.currencyFrom = new System.Windows.Forms.ComboBox();
            this.calculateButtonCurr = new System.Windows.Forms.Button();
            this.convertLabelCurr = new System.Windows.Forms.Label();
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
            this.label4.TabIndex = 35;
            this.label4.Text = "Total:";
            // 
            // inputValueCurr
            // 
            this.inputValueCurr.Location = new System.Drawing.Point(150, 171);
            this.inputValueCurr.Name = "inputValueCurr";
            this.inputValueCurr.Size = new System.Drawing.Size(151, 27);
            this.inputValueCurr.TabIndex = 34;
            // 
            // currencyTo
            // 
            this.currencyTo.FormattingEnabled = true;
            this.currencyTo.Location = new System.Drawing.Point(150, 119);
            this.currencyTo.Name = "currencyTo";
            this.currencyTo.Size = new System.Drawing.Size(151, 28);
            this.currencyTo.TabIndex = 33;
            // 
            // currencyFrom
            // 
            this.currencyFrom.FormattingEnabled = true;
            this.currencyFrom.Location = new System.Drawing.Point(150, 72);
            this.currencyFrom.Name = "currencyFrom";
            this.currencyFrom.Size = new System.Drawing.Size(151, 28);
            this.currencyFrom.TabIndex = 32;
            // 
            // calculateButtonCurr
            // 
            this.calculateButtonCurr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButtonCurr.Location = new System.Drawing.Point(150, 228);
            this.calculateButtonCurr.Name = "calculateButtonCurr";
            this.calculateButtonCurr.Size = new System.Drawing.Size(101, 38);
            this.calculateButtonCurr.TabIndex = 31;
            this.calculateButtonCurr.Text = "Calculate";
            this.calculateButtonCurr.UseVisualStyleBackColor = true;
            this.calculateButtonCurr.Click += new System.EventHandler(this.calculateButtonCurr_Click);
            // 
            // convertLabelCurr
            // 
            this.convertLabelCurr.AutoSize = true;
            this.convertLabelCurr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertLabelCurr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.convertLabelCurr.Location = new System.Drawing.Point(150, 290);
            this.convertLabelCurr.Name = "convertLabelCurr";
            this.convertLabelCurr.Size = new System.Drawing.Size(0, 28);
            this.convertLabelCurr.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(59, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 28);
            this.label3.TabIndex = 29;
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
            this.label2.TabIndex = 28;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(59, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Value";
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(376, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputValueCurr);
            this.Controls.Add(this.currencyTo);
            this.Controls.Add(this.currencyFrom);
            this.Controls.Add(this.calculateButtonCurr);
            this.Controls.Add(this.convertLabelCurr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CurrencyConverter";
            this.Text = "CurrencyConverter";
            this.Load += new System.EventHandler(this.CurrencyConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputValueCurr;
        private System.Windows.Forms.ComboBox currencyTo;
        private System.Windows.Forms.ComboBox currencyFrom;
        private System.Windows.Forms.Button calculateButtonCurr;
        private System.Windows.Forms.Label convertLabelCurr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}