namespace Lab_3
{
    partial class GeoValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoValue));
            this.labelRad = new System.Windows.Forms.Label();
            this.inputRad = new System.Windows.Forms.TextBox();
            this.labelDiam = new System.Windows.Forms.Label();
            this.outputDiam = new System.Windows.Forms.Label();
            this.labelSurf = new System.Windows.Forms.Label();
            this.outputSurf = new System.Windows.Forms.Label();
            this.labelVol = new System.Windows.Forms.Label();
            this.outputVol = new System.Windows.Forms.Label();
            this.buttonCal = new System.Windows.Forms.Button();
            this.picSphereTop = new System.Windows.Forms.PictureBox();
            this.picSphereBot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSphereTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSphereBot)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRad
            // 
            this.labelRad.AutoSize = true;
            this.labelRad.Location = new System.Drawing.Point(179, 31);
            this.labelRad.Name = "labelRad";
            this.labelRad.Size = new System.Drawing.Size(87, 13);
            this.labelRad.TabIndex = 0;
            this.labelRad.Text = "Radius of sphere";
            // 
            // inputRad
            // 
            this.inputRad.Location = new System.Drawing.Point(272, 28);
            this.inputRad.Name = "inputRad";
            this.inputRad.Size = new System.Drawing.Size(100, 20);
            this.inputRad.TabIndex = 1;
            // 
            // labelDiam
            // 
            this.labelDiam.AutoSize = true;
            this.labelDiam.Location = new System.Drawing.Point(34, 209);
            this.labelDiam.Name = "labelDiam";
            this.labelDiam.Size = new System.Drawing.Size(49, 13);
            this.labelDiam.TabIndex = 2;
            this.labelDiam.Text = "Diameter";
            // 
            // outputDiam
            // 
            this.outputDiam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDiam.Location = new System.Drawing.Point(89, 204);
            this.outputDiam.Name = "outputDiam";
            this.outputDiam.Size = new System.Drawing.Size(100, 23);
            this.outputDiam.TabIndex = 3;
            this.outputDiam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSurf
            // 
            this.labelSurf.AutoSize = true;
            this.labelSurf.Location = new System.Drawing.Point(14, 252);
            this.labelSurf.Name = "labelSurf";
            this.labelSurf.Size = new System.Drawing.Size(69, 13);
            this.labelSurf.TabIndex = 4;
            this.labelSurf.Text = "Surface Area";
            // 
            // outputSurf
            // 
            this.outputSurf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputSurf.Location = new System.Drawing.Point(89, 247);
            this.outputSurf.Name = "outputSurf";
            this.outputSurf.Size = new System.Drawing.Size(100, 23);
            this.outputSurf.TabIndex = 5;
            this.outputSurf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVol
            // 
            this.labelVol.AutoSize = true;
            this.labelVol.Location = new System.Drawing.Point(41, 296);
            this.labelVol.Name = "labelVol";
            this.labelVol.Size = new System.Drawing.Size(42, 13);
            this.labelVol.TabIndex = 6;
            this.labelVol.Text = "Volume";
            // 
            // outputVol
            // 
            this.outputVol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputVol.Location = new System.Drawing.Point(89, 291);
            this.outputVol.Name = "outputVol";
            this.outputVol.Size = new System.Drawing.Size(100, 23);
            this.outputVol.TabIndex = 7;
            this.outputVol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCal
            // 
            this.buttonCal.Location = new System.Drawing.Point(284, 63);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Size = new System.Drawing.Size(75, 23);
            this.buttonCal.TabIndex = 8;
            this.buttonCal.Text = "Calculate";
            this.buttonCal.UseVisualStyleBackColor = true;
            this.buttonCal.Click += new System.EventHandler(this.buttonCal_Click);
            // 
            // picSphereTop
            // 
            this.picSphereTop.Image = ((System.Drawing.Image)(resources.GetObject("picSphereTop.Image")));
            this.picSphereTop.Location = new System.Drawing.Point(12, 12);
            this.picSphereTop.Name = "picSphereTop";
            this.picSphereTop.Size = new System.Drawing.Size(150, 150);
            this.picSphereTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSphereTop.TabIndex = 9;
            this.picSphereTop.TabStop = false;
            // 
            // picSphereBot
            // 
            this.picSphereBot.Image = ((System.Drawing.Image)(resources.GetObject("picSphereBot.Image")));
            this.picSphereBot.Location = new System.Drawing.Point(222, 184);
            this.picSphereBot.Name = "picSphereBot";
            this.picSphereBot.Size = new System.Drawing.Size(150, 150);
            this.picSphereBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSphereBot.TabIndex = 10;
            this.picSphereBot.TabStop = false;
            // 
            // GeoValue
            // 
            this.AcceptButton = this.buttonCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.picSphereBot);
            this.Controls.Add(this.picSphereTop);
            this.Controls.Add(this.buttonCal);
            this.Controls.Add(this.outputVol);
            this.Controls.Add(this.labelVol);
            this.Controls.Add(this.outputSurf);
            this.Controls.Add(this.labelSurf);
            this.Controls.Add(this.outputDiam);
            this.Controls.Add(this.labelDiam);
            this.Controls.Add(this.inputRad);
            this.Controls.Add(this.labelRad);
            this.Name = "GeoValue";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.picSphereTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSphereBot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRad;
        private System.Windows.Forms.TextBox inputRad;
        private System.Windows.Forms.Label labelDiam;
        private System.Windows.Forms.Label outputDiam;
        private System.Windows.Forms.Label labelSurf;
        private System.Windows.Forms.Label outputSurf;
        private System.Windows.Forms.Label labelVol;
        private System.Windows.Forms.Label outputVol;
        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.PictureBox picSphereTop;
        private System.Windows.Forms.PictureBox picSphereBot;
    }
}

