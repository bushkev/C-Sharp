namespace Problem2
{
    partial class Problem2
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
            this.labelLetter = new System.Windows.Forms.Label();
            this.inputLetter = new System.Windows.Forms.TextBox();
            this.labelGpa = new System.Windows.Forms.Label();
            this.inputGpa = new System.Windows.Forms.TextBox();
            this.buttonCal = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.outputDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.outputTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLetter
            // 
            this.labelLetter.AutoSize = true;
            this.labelLetter.Location = new System.Drawing.Point(89, 12);
            this.labelLetter.Name = "labelLetter";
            this.labelLetter.Size = new System.Drawing.Size(56, 13);
            this.labelLetter.TabIndex = 0;
            this.labelLetter.Text = "Last name";
            // 
            // inputLetter
            // 
            this.inputLetter.Location = new System.Drawing.Point(151, 9);
            this.inputLetter.Name = "inputLetter";
            this.inputLetter.Size = new System.Drawing.Size(76, 20);
            this.inputLetter.TabIndex = 1;
            // 
            // labelGpa
            // 
            this.labelGpa.AutoSize = true;
            this.labelGpa.Location = new System.Drawing.Point(82, 40);
            this.labelGpa.Name = "labelGpa";
            this.labelGpa.Size = new System.Drawing.Size(63, 13);
            this.labelGpa.TabIndex = 2;
            this.labelGpa.Text = "Credit hours";
            // 
            // inputGpa
            // 
            this.inputGpa.Location = new System.Drawing.Point(151, 37);
            this.inputGpa.Name = "inputGpa";
            this.inputGpa.Size = new System.Drawing.Size(76, 20);
            this.inputGpa.TabIndex = 3;
            // 
            // buttonCal
            // 
            this.buttonCal.Location = new System.Drawing.Point(151, 72);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Size = new System.Drawing.Size(75, 23);
            this.buttonCal.TabIndex = 4;
            this.buttonCal.Text = "Generate";
            this.buttonCal.UseVisualStyleBackColor = true;
            this.buttonCal.Click += new System.EventHandler(this.buttonCal_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(30, 117);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(115, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Your register begins on";
            // 
            // outputDate
            // 
            this.outputDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDate.Location = new System.Drawing.Point(151, 112);
            this.outputDate.Name = "outputDate";
            this.outputDate.Size = new System.Drawing.Size(76, 23);
            this.outputDate.TabIndex = 6;
            this.outputDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(74, 152);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(71, 13);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "no ealier than";
            // 
            // outputTime
            // 
            this.outputTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTime.Location = new System.Drawing.Point(151, 147);
            this.outputTime.Name = "outputTime";
            this.outputTime.Size = new System.Drawing.Size(76, 23);
            this.outputTime.TabIndex = 8;
            this.outputTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Problem2
            // 
            this.AcceptButton = this.buttonCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 195);
            this.Controls.Add(this.outputTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.outputDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonCal);
            this.Controls.Add(this.inputGpa);
            this.Controls.Add(this.labelGpa);
            this.Controls.Add(this.inputLetter);
            this.Controls.Add(this.labelLetter);
            this.Name = "Problem2";
            this.Text = "Registration date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLetter;
        private System.Windows.Forms.TextBox inputLetter;
        private System.Windows.Forms.Label labelGpa;
        private System.Windows.Forms.TextBox inputGpa;
        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label outputDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label outputTime;
    }
}

