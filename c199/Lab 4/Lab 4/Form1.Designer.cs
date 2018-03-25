namespace Lab_4
{
    partial class AdTestForm
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
            this.labelGpa = new System.Windows.Forms.Label();
            this.inputGpa = new System.Windows.Forms.TextBox();
            this.labelTest = new System.Windows.Forms.Label();
            this.inputTest = new System.Windows.Forms.TextBox();
            this.butCal = new System.Windows.Forms.Button();
            this.outputAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGpa
            // 
            this.labelGpa.AutoSize = true;
            this.labelGpa.Location = new System.Drawing.Point(31, 30);
            this.labelGpa.Name = "labelGpa";
            this.labelGpa.Size = new System.Drawing.Size(106, 13);
            this.labelGpa.TabIndex = 0;
            this.labelGpa.Text = "Grade Point Average";
            // 
            // inputGpa
            // 
            this.inputGpa.Location = new System.Drawing.Point(143, 27);
            this.inputGpa.Name = "inputGpa";
            this.inputGpa.Size = new System.Drawing.Size(100, 20);
            this.inputGpa.TabIndex = 1;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(31, 63);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(106, 13);
            this.labelTest.TabIndex = 2;
            this.labelTest.Text = "AdmissionTest Score";
            // 
            // inputTest
            // 
            this.inputTest.Location = new System.Drawing.Point(143, 60);
            this.inputTest.Name = "inputTest";
            this.inputTest.Size = new System.Drawing.Size(100, 20);
            this.inputTest.TabIndex = 3;
            // 
            // butCal
            // 
            this.butCal.Location = new System.Drawing.Point(143, 95);
            this.butCal.Name = "butCal";
            this.butCal.Size = new System.Drawing.Size(100, 23);
            this.butCal.TabIndex = 4;
            this.butCal.Text = "Check Status";
            this.butCal.UseVisualStyleBackColor = true;
            this.butCal.Click += new System.EventHandler(this.butCal_Click);
            // 
            // outputAns
            // 
            this.outputAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputAns.Location = new System.Drawing.Point(143, 136);
            this.outputAns.Name = "outputAns";
            this.outputAns.Size = new System.Drawing.Size(100, 23);
            this.outputAns.TabIndex = 5;
            // 
            // AdTestForm
            // 
            this.AcceptButton = this.butCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.outputAns);
            this.Controls.Add(this.butCal);
            this.Controls.Add(this.inputTest);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.inputGpa);
            this.Controls.Add(this.labelGpa);
            this.Name = "AdTestForm";
            this.Text = "Admissions Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGpa;
        private System.Windows.Forms.TextBox inputGpa;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.TextBox inputTest;
        private System.Windows.Forms.Button butCal;
        private System.Windows.Forms.Label outputAns;
    }
}

