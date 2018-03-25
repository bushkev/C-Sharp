namespace Program_1
{
    partial class PaintForm
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
            this.labelWallLen = new System.Windows.Forms.Label();
            this.inputWallLen = new System.Windows.Forms.TextBox();
            this.labelWallHeight = new System.Windows.Forms.Label();
            this.inputWallHeight = new System.Windows.Forms.TextBox();
            this.labelDoor = new System.Windows.Forms.Label();
            this.inputDoor = new System.Windows.Forms.TextBox();
            this.labelWin = new System.Windows.Forms.Label();
            this.inputWin = new System.Windows.Forms.TextBox();
            this.labelCoat = new System.Windows.Forms.Label();
            this.inputCoat = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.inputCost = new System.Windows.Forms.TextBox();
            this.butCal = new System.Windows.Forms.Button();
            this.labelMinAm = new System.Windows.Forms.Label();
            this.outputMinAmt = new System.Windows.Forms.Label();
            this.labelTrueAm = new System.Windows.Forms.Label();
            this.outputTrueAmt = new System.Windows.Forms.Label();
            this.labelTotCost = new System.Windows.Forms.Label();
            this.outputTotCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWallLen
            // 
            this.labelWallLen.AutoSize = true;
            this.labelWallLen.Location = new System.Drawing.Point(11, 9);
            this.labelWallLen.Name = "labelWallLen";
            this.labelWallLen.Size = new System.Drawing.Size(155, 13);
            this.labelWallLen.TabIndex = 0;
            this.labelWallLen.Text = "Total length of all walls (in feet) ";
            // 
            // inputWallLen
            // 
            this.inputWallLen.Location = new System.Drawing.Point(172, 6);
            this.inputWallLen.Name = "inputWallLen";
            this.inputWallLen.Size = new System.Drawing.Size(100, 20);
            this.inputWallLen.TabIndex = 1;
            // 
            // labelWallHeight
            // 
            this.labelWallHeight.AutoSize = true;
            this.labelWallHeight.Location = new System.Drawing.Point(49, 35);
            this.labelWallHeight.Name = "labelWallHeight";
            this.labelWallHeight.Size = new System.Drawing.Size(117, 13);
            this.labelWallHeight.TabIndex = 2;
            this.labelWallHeight.Text = "Height of Walls (in feet)";
            // 
            // inputWallHeight
            // 
            this.inputWallHeight.Location = new System.Drawing.Point(172, 32);
            this.inputWallHeight.Name = "inputWallHeight";
            this.inputWallHeight.Size = new System.Drawing.Size(100, 20);
            this.inputWallHeight.TabIndex = 3;
            // 
            // labelDoor
            // 
            this.labelDoor.AutoSize = true;
            this.labelDoor.Location = new System.Drawing.Point(81, 61);
            this.labelDoor.Name = "labelDoor";
            this.labelDoor.Size = new System.Drawing.Size(85, 13);
            this.labelDoor.TabIndex = 4;
            this.labelDoor.Text = "Number of doors";
            // 
            // inputDoor
            // 
            this.inputDoor.Location = new System.Drawing.Point(172, 58);
            this.inputDoor.Name = "inputDoor";
            this.inputDoor.Size = new System.Drawing.Size(100, 20);
            this.inputDoor.TabIndex = 5;
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Location = new System.Drawing.Point(66, 87);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(100, 13);
            this.labelWin.TabIndex = 6;
            this.labelWin.Text = "Number of windows";
            // 
            // inputWin
            // 
            this.inputWin.Location = new System.Drawing.Point(172, 84);
            this.inputWin.Name = "inputWin";
            this.inputWin.Size = new System.Drawing.Size(100, 20);
            this.inputWin.TabIndex = 7;
            // 
            // labelCoat
            // 
            this.labelCoat.AutoSize = true;
            this.labelCoat.Location = new System.Drawing.Point(80, 113);
            this.labelCoat.Name = "labelCoat";
            this.labelCoat.Size = new System.Drawing.Size(86, 13);
            this.labelCoat.TabIndex = 8;
            this.labelCoat.Text = "Number of Coats";
            // 
            // inputCoat
            // 
            this.inputCoat.Location = new System.Drawing.Point(172, 110);
            this.inputCoat.Name = "inputCoat";
            this.inputCoat.Size = new System.Drawing.Size(100, 20);
            this.inputCoat.TabIndex = 9;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(51, 139);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(115, 13);
            this.labelCost.TabIndex = 10;
            this.labelCost.Text = "Cost of paint per gallon";
            // 
            // inputCost
            // 
            this.inputCost.Location = new System.Drawing.Point(172, 136);
            this.inputCost.Name = "inputCost";
            this.inputCost.Size = new System.Drawing.Size(100, 20);
            this.inputCost.TabIndex = 11;
            // 
            // butCal
            // 
            this.butCal.Location = new System.Drawing.Point(172, 173);
            this.butCal.Name = "butCal";
            this.butCal.Size = new System.Drawing.Size(100, 23);
            this.butCal.TabIndex = 12;
            this.butCal.Text = "Calculate";
            this.butCal.UseVisualStyleBackColor = true;
            this.butCal.Click += new System.EventHandler(this.butCal_Click);
            // 
            // labelMinAm
            // 
            this.labelMinAm.AutoSize = true;
            this.labelMinAm.Location = new System.Drawing.Point(5, 222);
            this.labelMinAm.Name = "labelMinAm";
            this.labelMinAm.Size = new System.Drawing.Size(161, 13);
            this.labelMinAm.TabIndex = 13;
            this.labelMinAm.Text = "Minimum gallons of paint needed";
            // 
            // outputMinAmt
            // 
            this.outputMinAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputMinAmt.Location = new System.Drawing.Point(172, 217);
            this.outputMinAmt.Name = "outputMinAmt";
            this.outputMinAmt.Size = new System.Drawing.Size(100, 23);
            this.outputMinAmt.TabIndex = 14;
            this.outputMinAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTrueAm
            // 
            this.labelTrueAm.AutoSize = true;
            this.labelTrueAm.Location = new System.Drawing.Point(9, 253);
            this.labelTrueAm.Name = "labelTrueAm";
            this.labelTrueAm.Size = new System.Drawing.Size(157, 13);
            this.labelTrueAm.TabIndex = 15;
            this.labelTrueAm.Text = "Number of gallons you must buy";
            // 
            // outputTrueAmt
            // 
            this.outputTrueAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTrueAmt.Location = new System.Drawing.Point(172, 248);
            this.outputTrueAmt.Name = "outputTrueAmt";
            this.outputTrueAmt.Size = new System.Drawing.Size(100, 23);
            this.outputTrueAmt.TabIndex = 16;
            this.outputTrueAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotCost
            // 
            this.labelTotCost.AutoSize = true;
            this.labelTotCost.Location = new System.Drawing.Point(91, 283);
            this.labelTotCost.Name = "labelTotCost";
            this.labelTotCost.Size = new System.Drawing.Size(75, 13);
            this.labelTotCost.TabIndex = 17;
            this.labelTotCost.Text = "Your total cost";
            // 
            // outputTotCost
            // 
            this.outputTotCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTotCost.Location = new System.Drawing.Point(172, 278);
            this.outputTotCost.Name = "outputTotCost";
            this.outputTotCost.Size = new System.Drawing.Size(100, 23);
            this.outputTotCost.TabIndex = 18;
            this.outputTotCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 324);
            this.Controls.Add(this.outputTotCost);
            this.Controls.Add(this.labelTotCost);
            this.Controls.Add(this.outputTrueAmt);
            this.Controls.Add(this.labelTrueAm);
            this.Controls.Add(this.outputMinAmt);
            this.Controls.Add(this.labelMinAm);
            this.Controls.Add(this.butCal);
            this.Controls.Add(this.inputCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.inputCoat);
            this.Controls.Add(this.labelCoat);
            this.Controls.Add(this.inputWin);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.inputDoor);
            this.Controls.Add(this.labelDoor);
            this.Controls.Add(this.inputWallHeight);
            this.Controls.Add(this.labelWallHeight);
            this.Controls.Add(this.inputWallLen);
            this.Controls.Add(this.labelWallLen);
            this.Name = "PaintForm";
            this.Text = "Paint Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWallLen;
        private System.Windows.Forms.TextBox inputWallLen;
        private System.Windows.Forms.Label labelWallHeight;
        private System.Windows.Forms.TextBox inputWallHeight;
        private System.Windows.Forms.Label labelDoor;
        private System.Windows.Forms.TextBox inputDoor;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.TextBox inputWin;
        private System.Windows.Forms.Label labelCoat;
        private System.Windows.Forms.TextBox inputCoat;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox inputCost;
        private System.Windows.Forms.Button butCal;
        private System.Windows.Forms.Label labelMinAm;
        private System.Windows.Forms.Label outputMinAmt;
        private System.Windows.Forms.Label labelTrueAm;
        private System.Windows.Forms.Label outputTrueAmt;
        private System.Windows.Forms.Label labelTotCost;
        private System.Windows.Forms.Label outputTotCost;
    }
}

