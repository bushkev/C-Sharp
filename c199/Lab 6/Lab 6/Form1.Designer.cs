namespace Lab_6
{
    partial class Lab6
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
            this.labelWord = new System.Windows.Forms.Label();
            this.inputWord = new System.Windows.Forms.TextBox();
            this.calButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Location = new System.Drawing.Point(12, 20);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(142, 13);
            this.labelWord.TabIndex = 0;
            this.labelWord.Text = "Enter number of words typed";
            // 
            // inputWord
            // 
            this.inputWord.AcceptsReturn = true;
            this.inputWord.Location = new System.Drawing.Point(160, 17);
            this.inputWord.Name = "inputWord";
            this.inputWord.Size = new System.Drawing.Size(65, 20);
            this.inputWord.TabIndex = 1;
            // 
            // calButton
            // 
            this.calButton.Location = new System.Drawing.Point(79, 45);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(75, 23);
            this.calButton.TabIndex = 2;
            this.calButton.Text = "Calculate";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(160, 50);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(65, 18);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab6
            // 
            this.AcceptButton = this.calButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 85);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.inputWord);
            this.Controls.Add(this.labelWord);
            this.Name = "Lab6";
            this.Text = "WPM Grader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.TextBox inputWord;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

