namespace Lab_7
{
    partial class Lab7
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
            this.labelFutureValue = new System.Windows.Forms.Label();
            this.inputFutVal = new System.Windows.Forms.TextBox();
            this.labelIntRate = new System.Windows.Forms.Label();
            this.inputIntRate = new System.Windows.Forms.TextBox();
            this.labelNumYear = new System.Windows.Forms.Label();
            this.inputNumYear = new System.Windows.Forms.TextBox();
            this.labelPresentValue = new System.Windows.Forms.Label();
            this.outputPresentValue = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFutureValue
            // 
            this.labelFutureValue.AutoSize = true;
            this.labelFutureValue.Location = new System.Drawing.Point(35, 26);
            this.labelFutureValue.Name = "labelFutureValue";
            this.labelFutureValue.Size = new System.Drawing.Size(70, 13);
            this.labelFutureValue.TabIndex = 0;
            this.labelFutureValue.Text = "Future Value:";
            // 
            // inputFutVal
            // 
            this.inputFutVal.Location = new System.Drawing.Point(172, 23);
            this.inputFutVal.Name = "inputFutVal";
            this.inputFutVal.Size = new System.Drawing.Size(100, 20);
            this.inputFutVal.TabIndex = 1;
            // 
            // labelIntRate
            // 
            this.labelIntRate.AutoSize = true;
            this.labelIntRate.Location = new System.Drawing.Point(35, 52);
            this.labelIntRate.Name = "labelIntRate";
            this.labelIntRate.Size = new System.Drawing.Size(107, 13);
            this.labelIntRate.TabIndex = 2;
            this.labelIntRate.Text = "Annual Interest Rate:";
            // 
            // inputIntRate
            // 
            this.inputIntRate.Location = new System.Drawing.Point(172, 49);
            this.inputIntRate.Name = "inputIntRate";
            this.inputIntRate.Size = new System.Drawing.Size(100, 20);
            this.inputIntRate.TabIndex = 3;
            // 
            // labelNumYear
            // 
            this.labelNumYear.AutoSize = true;
            this.labelNumYear.Location = new System.Drawing.Point(35, 78);
            this.labelNumYear.Name = "labelNumYear";
            this.labelNumYear.Size = new System.Drawing.Size(92, 13);
            this.labelNumYear.TabIndex = 4;
            this.labelNumYear.Text = "Number of Years: ";
            // 
            // inputNumYear
            // 
            this.inputNumYear.Location = new System.Drawing.Point(172, 75);
            this.inputNumYear.Name = "inputNumYear";
            this.inputNumYear.Size = new System.Drawing.Size(100, 20);
            this.inputNumYear.TabIndex = 5;
            // 
            // labelPresentValue
            // 
            this.labelPresentValue.AutoSize = true;
            this.labelPresentValue.Location = new System.Drawing.Point(35, 103);
            this.labelPresentValue.Name = "labelPresentValue";
            this.labelPresentValue.Size = new System.Drawing.Size(79, 13);
            this.labelPresentValue.TabIndex = 6;
            this.labelPresentValue.Text = "Present Value: ";
            // 
            // outputPresentValue
            // 
            this.outputPresentValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPresentValue.Location = new System.Drawing.Point(172, 98);
            this.outputPresentValue.Name = "outputPresentValue";
            this.outputPresentValue.Size = new System.Drawing.Size(100, 23);
            this.outputPresentValue.TabIndex = 7;
            this.outputPresentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(98, 135);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Lab7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 169);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.outputPresentValue);
            this.Controls.Add(this.labelPresentValue);
            this.Controls.Add(this.inputNumYear);
            this.Controls.Add(this.labelNumYear);
            this.Controls.Add(this.inputIntRate);
            this.Controls.Add(this.labelIntRate);
            this.Controls.Add(this.inputFutVal);
            this.Controls.Add(this.labelFutureValue);
            this.Name = "Lab7";
            this.Text = "Future money";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFutureValue;
        private System.Windows.Forms.TextBox inputFutVal;
        private System.Windows.Forms.Label labelIntRate;
        private System.Windows.Forms.TextBox inputIntRate;
        private System.Windows.Forms.Label labelNumYear;
        private System.Windows.Forms.TextBox inputNumYear;
        private System.Windows.Forms.Label labelPresentValue;
        private System.Windows.Forms.Label outputPresentValue;
        private System.Windows.Forms.Button calcButton;
    }
}

