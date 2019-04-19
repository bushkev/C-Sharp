namespace UPVApp
{
    partial class EditAddress
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
            this.components = new System.ComponentModel.Container();
            this.infoLabel = new System.Windows.Forms.Label();
            this.editBox = new System.Windows.Forms.ComboBox();
            this.butSubmit = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(196, 13);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Choose the address you wish to change";
            // 
            // editBox
            // 
            this.editBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editBox.FormattingEnabled = true;
            this.editBox.Location = new System.Drawing.Point(15, 35);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(193, 21);
            this.editBox.TabIndex = 1;
            this.editBox.Validating += new System.ComponentModel.CancelEventHandler(this.editBox_Validating);
            this.editBox.Validated += new System.EventHandler(this.editBox_Validated);
            // 
            // butSubmit
            // 
            this.butSubmit.Location = new System.Drawing.Point(27, 74);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(75, 23);
            this.butSubmit.TabIndex = 2;
            this.butSubmit.Text = "OK";
            this.butSubmit.UseVisualStyleBackColor = true;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(122, 74);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.butCancel_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditAddress
            // 
            this.AcceptButton = this.butSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(223, 111);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.infoLabel);
            this.Name = "EditAddress";
            this.Text = "Edit Address";
            this.Load += new System.EventHandler(this.EditAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ComboBox editBox;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}