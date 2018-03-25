namespace Lab_2
{
    partial class Form1
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
            this.labelPrice = new System.Windows.Forms.Label();
            this.boxPrice = new System.Windows.Forms.TextBox();
            this.labelLowTip = new System.Windows.Forms.Label();
            this.labelMidTip = new System.Windows.Forms.Label();
            this.labelHighTip = new System.Windows.Forms.Label();
            this.CalButton = new System.Windows.Forms.Button();
            this.labelLowOut = new System.Windows.Forms.Label();
            this.labelMidOut = new System.Windows.Forms.Label();
            this.labelHighOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(29, 39);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(98, 13);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Enter price of meal:";
            // 
            // boxPrice
            // 
            this.boxPrice.Location = new System.Drawing.Point(133, 36);
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(100, 20);
            this.boxPrice.TabIndex = 1;
            // 
            // labelLowTip
            // 
            this.labelLowTip.AutoSize = true;
            this.labelLowTip.Location = new System.Drawing.Point(97, 77);
            this.labelLowTip.Name = "labelLowTip";
            this.labelLowTip.Size = new System.Drawing.Size(0, 13);
            this.labelLowTip.TabIndex = 2;
            // 
            // labelMidTip
            // 
            this.labelMidTip.AutoSize = true;
            this.labelMidTip.Location = new System.Drawing.Point(97, 117);
            this.labelMidTip.Name = "labelMidTip";
            this.labelMidTip.Size = new System.Drawing.Size(0, 13);
            this.labelMidTip.TabIndex = 4;
            // 
            // labelHighTip
            // 
            this.labelHighTip.AutoSize = true;
            this.labelHighTip.Location = new System.Drawing.Point(97, 155);
            this.labelHighTip.Name = "labelHighTip";
            this.labelHighTip.Size = new System.Drawing.Size(0, 13);
            this.labelHighTip.TabIndex = 6;
            // 
            // CalButton
            // 
            this.CalButton.Location = new System.Drawing.Point(100, 200);
            this.CalButton.Name = "CalButton";
            this.CalButton.Size = new System.Drawing.Size(92, 23);
            this.CalButton.TabIndex = 8;
            this.CalButton.Text = "Calculate Tip";
            this.CalButton.UseVisualStyleBackColor = true;
            this.CalButton.Click += new System.EventHandler(this.CalButton_Click);
            // 
            // labelLowOut
            // 
            this.labelLowOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLowOut.Location = new System.Drawing.Point(133, 76);
            this.labelLowOut.Name = "labelLowOut";
            this.labelLowOut.Size = new System.Drawing.Size(100, 23);
            this.labelLowOut.TabIndex = 3;
            // 
            // labelMidOut
            // 
            this.labelMidOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMidOut.Location = new System.Drawing.Point(133, 116);
            this.labelMidOut.Name = "labelMidOut";
            this.labelMidOut.Size = new System.Drawing.Size(100, 23);
            this.labelMidOut.TabIndex = 5;
            // 
            // labelHighOut
            // 
            this.labelHighOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHighOut.Location = new System.Drawing.Point(133, 154);
            this.labelHighOut.Name = "labelHighOut";
            this.labelHighOut.Size = new System.Drawing.Size(100, 23);
            this.labelHighOut.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.CalButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelHighOut);
            this.Controls.Add(this.labelMidOut);
            this.Controls.Add(this.labelLowOut);
            this.Controls.Add(this.CalButton);
            this.Controls.Add(this.labelHighTip);
            this.Controls.Add(this.labelMidTip);
            this.Controls.Add(this.labelLowTip);
            this.Controls.Add(this.boxPrice);
            this.Controls.Add(this.labelPrice);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox boxPrice;
        private System.Windows.Forms.Label labelLowTip;
        private System.Windows.Forms.Label labelMidTip;
        private System.Windows.Forms.Label labelHighTip;
        private System.Windows.Forms.Button CalButton;
        private System.Windows.Forms.Label labelLowOut;
        private System.Windows.Forms.Label labelMidOut;
        private System.Windows.Forms.Label labelHighOut;
    }
}

