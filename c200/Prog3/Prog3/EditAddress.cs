// Program 3
// CIS 200-01
// Fall 2018
// Due: 12 November 2018
// By: D9689
//
// dialog box that allows you to choose which address to edit 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class EditAddress : Form
    {
        List<Address> addList = new List<Address>();    //list of addresses used to populate the combo box.

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display
        public EditAddress(List<Address> list)
        {
            InitializeComponent();

            addList = list;
        }

        // Precondition:  none
        // Postcondition: The list of addresses is used to populate the combo box
        private void EditAddress_Load(object sender, EventArgs e)
        {
            foreach(var item in addList)
            {
                editBox.Items.Add(item);
            }
        }

        internal int SelectedIndex
        {
            // Precondition:  User has selected from editBox
            // Postcondition: The index of the selected address is returned
            get => editBox.SelectedIndex;

        }

        // Precondition:  User clicked on Submit button
        // Postcondition: If invalid field on dialog, keep form open and give error.
        //                else return OK and close form.
        private void butSubmit_Click(object sender, EventArgs e)
        {

            // If all pass, ValidateChildren() will be true
            if (ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }            
        }

        // Precondition:  User pressed on cancelBtn
        // Postcondition: Form closes
        private void butCancel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }

        //precondition: must not be empty or null
        //postcondition: passed validating
        private void editBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(editBox.Text))
            {
                errorProvider1.SetError(editBox, "Must choose an address!");
                e.Cancel = true;
            }
        }

        //precondition: passed validating
        //postcondition: clears error message
        private void editBox_Validated(object sender, EventArgs e)
        {
           errorProvider1.SetError(editBox, "");
        }
    }
}
