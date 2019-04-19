namespace UPVApp
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileTab = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSub = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSub = new System.Windows.Forms.ToolStripMenuItem();
            this.insertTab = new System.Windows.Forms.ToolStripMenuItem();
            this.addressSub = new System.Windows.Forms.ToolStripMenuItem();
            this.letterSub = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTab,
            this.insertTab,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileTab
            // 
            this.fileTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSub,
            this.exitSub});
            this.fileTab.Name = "fileTab";
            this.fileTab.Size = new System.Drawing.Size(37, 20);
            this.fileTab.Text = "&File";
            // 
            // aboutSub
            // 
            this.aboutSub.Name = "aboutSub";
            this.aboutSub.Size = new System.Drawing.Size(107, 22);
            this.aboutSub.Text = "About";
            this.aboutSub.Click += new System.EventHandler(this.aboutSub_Click);
            // 
            // exitSub
            // 
            this.exitSub.Name = "exitSub";
            this.exitSub.Size = new System.Drawing.Size(107, 22);
            this.exitSub.Text = "Exit";
            this.exitSub.Click += new System.EventHandler(this.exitSub_Click);
            // 
            // insertTab
            // 
            this.insertTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressSub,
            this.letterSub});
            this.insertTab.Name = "insertTab";
            this.insertTab.Size = new System.Drawing.Size(48, 20);
            this.insertTab.Text = "&Insert";
            // 
            // addressSub
            // 
            this.addressSub.Name = "addressSub";
            this.addressSub.Size = new System.Drawing.Size(180, 22);
            this.addressSub.Text = "Address";
            this.addressSub.Click += new System.EventHandler(this.addressSub_Click);
            // 
            // letterSub
            // 
            this.letterSub.Name = "letterSub";
            this.letterSub.Size = new System.Drawing.Size(180, 22);
            this.letterSub.Text = "Letter";
            this.letterSub.Click += new System.EventHandler(this.letterSub_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressesToolStripMenuItem,
            this.parcelsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "&Report";
            // 
            // addressesToolStripMenuItem
            // 
            this.addressesToolStripMenuItem.Name = "addressesToolStripMenuItem";
            this.addressesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addressesToolStripMenuItem.Text = "List Addresses";
            this.addressesToolStripMenuItem.Click += new System.EventHandler(this.addressesToolStripMenuItem_Click);
            // 
            // parcelsToolStripMenuItem
            // 
            this.parcelsToolStripMenuItem.Name = "parcelsToolStripMenuItem";
            this.parcelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parcelsToolStripMenuItem.Text = "List Parcels";
            this.parcelsToolStripMenuItem.Click += new System.EventHandler(this.parcelsToolStripMenuItem_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Location = new System.Drawing.Point(0, 24);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(284, 238);
            this.outputTextBox.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "User Parcel View";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileTab;
        private System.Windows.Forms.ToolStripMenuItem aboutSub;
        private System.Windows.Forms.ToolStripMenuItem exitSub;
        private System.Windows.Forms.ToolStripMenuItem insertTab;
        private System.Windows.Forms.ToolStripMenuItem addressSub;
        private System.Windows.Forms.ToolStripMenuItem letterSub;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcelsToolStripMenuItem;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

