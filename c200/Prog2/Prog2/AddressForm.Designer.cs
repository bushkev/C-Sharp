namespace Prog2
{
    partial class AddressForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddressLine1 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputAddLine1 = new System.Windows.Forms.TextBox();
            this.inputAddLine2 = new System.Windows.Forms.TextBox();
            this.inputCity = new System.Windows.Forms.TextBox();
            this.inputStateBox = new System.Windows.Forms.ComboBox();
            this.inputZip = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelAddressLine1
            // 
            this.labelAddressLine1.AutoSize = true;
            this.labelAddressLine1.Location = new System.Drawing.Point(24, 42);
            this.labelAddressLine1.Name = "labelAddressLine1";
            this.labelAddressLine1.Size = new System.Drawing.Size(45, 13);
            this.labelAddressLine1.TabIndex = 1;
            this.labelAddressLine1.Text = "Address";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(24, 104);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "City";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(24, 130);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 3;
            this.labelState.Text = "State";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(24, 162);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(50, 13);
            this.labelZip.TabIndex = 4;
            this.labelZip.Text = "Zip Code";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(88, 9);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(162, 20);
            this.inputName.TabIndex = 5;
            this.inputName.Validating += new System.ComponentModel.CancelEventHandler(this.inputName_Validating);
            this.inputName.Validated += new System.EventHandler(this.inputName_Validated);
            // 
            // inputAddLine1
            // 
            this.inputAddLine1.Location = new System.Drawing.Point(88, 39);
            this.inputAddLine1.Name = "inputAddLine1";
            this.inputAddLine1.Size = new System.Drawing.Size(162, 20);
            this.inputAddLine1.TabIndex = 6;
            this.inputAddLine1.Validating += new System.ComponentModel.CancelEventHandler(this.inputAddLine1_Validating);
            this.inputAddLine1.Validated += new System.EventHandler(this.inputAddLine1_Validated);
            // 
            // inputAddLine2
            // 
            this.inputAddLine2.Location = new System.Drawing.Point(88, 65);
            this.inputAddLine2.Name = "inputAddLine2";
            this.inputAddLine2.Size = new System.Drawing.Size(162, 20);
            this.inputAddLine2.TabIndex = 7;
            // 
            // inputCity
            // 
            this.inputCity.Location = new System.Drawing.Point(88, 97);
            this.inputCity.Name = "inputCity";
            this.inputCity.Size = new System.Drawing.Size(162, 20);
            this.inputCity.TabIndex = 8;
            this.inputCity.Validating += new System.ComponentModel.CancelEventHandler(this.inputCity_Validating);
            this.inputCity.Validated += new System.EventHandler(this.inputCity_Validated);
            // 
            // inputStateBox
            // 
            this.inputStateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputStateBox.FormattingEnabled = true;
            this.inputStateBox.Items.AddRange(new object[] {
            "",
            "CA",
            "FL",
            "IN",
            "KY",
            "ME",
            "NH",
            "OH",
            "TN",
            "TX",
            "VA",
            "WV"});
            this.inputStateBox.Location = new System.Drawing.Point(88, 127);
            this.inputStateBox.Name = "inputStateBox";
            this.inputStateBox.Size = new System.Drawing.Size(48, 21);
            this.inputStateBox.TabIndex = 9;
            this.inputStateBox.Validating += new System.ComponentModel.CancelEventHandler(this.inputStateBox_Validating);
            this.inputStateBox.Validated += new System.EventHandler(this.inputStateBox_Validated);
            // 
            // inputZip
            // 
            this.inputZip.Location = new System.Drawing.Point(88, 159);
            this.inputZip.Name = "inputZip";
            this.inputZip.Size = new System.Drawing.Size(80, 20);
            this.inputZip.TabIndex = 10;
            this.inputZip.Validating += new System.ComponentModel.CancelEventHandler(this.inputZip_Validating);
            this.inputZip.Validated += new System.EventHandler(this.inputZip_Validated);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(24, 193);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(71, 23);
            this.buttonSubmit.TabIndex = 11;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(182, 193);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(68, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonCancel_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(101, 193);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear Form";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonClear_MouseDown);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 228);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.inputZip);
            this.Controls.Add(this.inputStateBox);
            this.Controls.Add(this.inputCity);
            this.Controls.Add(this.inputAddLine2);
            this.Controls.Add(this.inputAddLine1);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddressLine1);
            this.Controls.Add(this.labelName);
            this.Name = "AddressForm";
            this.Text = "Enter Address";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddressLine1;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputAddLine1;
        private System.Windows.Forms.TextBox inputAddLine2;
        private System.Windows.Forms.TextBox inputCity;
        private System.Windows.Forms.ComboBox inputStateBox;
        private System.Windows.Forms.TextBox inputZip;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonClear;
    }
}