namespace Prog2
{
    partial class LetterForm
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
            this.originLabel = new System.Windows.Forms.Label();
            this.originDropDown = new System.Windows.Forms.ComboBox();
            this.destLabel = new System.Windows.Forms.Label();
            this.destDropDown = new System.Windows.Forms.ComboBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.inputCost = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(12, 13);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(75, 13);
            this.originLabel.TabIndex = 0;
            this.originLabel.Text = "Origin Address";
            // 
            // originDropDown
            // 
            this.originDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originDropDown.FormattingEnabled = true;
            this.originDropDown.Location = new System.Drawing.Point(137, 10);
            this.originDropDown.Name = "originDropDown";
            this.originDropDown.Size = new System.Drawing.Size(121, 21);
            this.originDropDown.TabIndex = 1;
            this.originDropDown.Validating += new System.ComponentModel.CancelEventHandler(this.originDropDown_Validating);
            this.originDropDown.Validated += new System.EventHandler(this.originDropDown_Validated);
            // 
            // destLabel
            // 
            this.destLabel.AutoSize = true;
            this.destLabel.Location = new System.Drawing.Point(12, 43);
            this.destLabel.Name = "destLabel";
            this.destLabel.Size = new System.Drawing.Size(101, 13);
            this.destLabel.TabIndex = 2;
            this.destLabel.Text = "Destination Address";
            // 
            // destDropDown
            // 
            this.destDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destDropDown.FormattingEnabled = true;
            this.destDropDown.Location = new System.Drawing.Point(137, 43);
            this.destDropDown.Name = "destDropDown";
            this.destDropDown.Size = new System.Drawing.Size(121, 21);
            this.destDropDown.TabIndex = 3;
            this.destDropDown.Validating += new System.ComponentModel.CancelEventHandler(this.destDropDown_Validating);
            this.destDropDown.Validated += new System.EventHandler(this.destDropDown_Validated);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(12, 76);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(28, 13);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Cost";
            // 
            // inputCost
            // 
            this.inputCost.Location = new System.Drawing.Point(137, 76);
            this.inputCost.Name = "inputCost";
            this.inputCost.Size = new System.Drawing.Size(121, 20);
            this.inputCost.TabIndex = 5;
            this.inputCost.Validating += new System.ComponentModel.CancelEventHandler(this.inputCost_Validating);
            this.inputCost.Validated += new System.EventHandler(this.inputCost_Validated);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(137, 110);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonCancel_MouseDown);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(15, 110);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(109, 23);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 145);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.inputCost);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.destDropDown);
            this.Controls.Add(this.destLabel);
            this.Controls.Add(this.originDropDown);
            this.Controls.Add(this.originLabel);
            this.Name = "LetterForm";
            this.Text = "Create Letter";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.ComboBox originDropDown;
        private System.Windows.Forms.Label destLabel;
        private System.Windows.Forms.ComboBox destDropDown;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox inputCost;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}