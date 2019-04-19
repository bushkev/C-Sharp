/*Grading ID: D9689
 * Cis200-01
 * Program 2
 * Due Date: 10/24/2018
 * A form to take user input for creating an address.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prog2
{
    public partial class AddressForm : Form
    {
        public const int MIN_ZIP = 0;     // Minimum ZipCode value
        public const int MAX_ZIP = 99999; // Maximum ZipCode value

        //precondition: none
        //postcondition: initializes form
        public AddressForm()
        {
            InitializeComponent();
        }

        public string NameLine { get => inputName.Text; }           //getter for the name of the address
        public string AddLine1 { get => inputAddLine1.Text; }       //getter for the address line 1 of the address
        public string AddLine2 { get => inputAddLine2.Text; }       //getter for the address line 2 of the address
        public string City { get => inputCity.Text; }               //getter for the city of the address
        public string State { get => inputStateBox.Text; }          //getter for the state of the address
        public int Zip { get; set; }                                //auto generated getter and setter for the zip code of the address

        //precondition: must not be empty or null
        //postcondition: passed validating
        private void inputName_Validating(object sender, CancelEventArgs e)
        {
            //if null or empty hold focus and show error
            if (string.IsNullOrWhiteSpace(inputName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(inputName,"Cannot leave blank.");
                inputName.SelectAll();
            }
        }

        //precondition: All fields must pass validation
        //postcondition: closes form and returns OK DialogResult
        private void inputName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(inputName, "");
        }

        //precondition: must not be empty or null
        //postcondition: passed validating
        private void inputAddLine1_Validating(object sender, CancelEventArgs e)
        {
            //if null or empty hold focus and show error
            if (string.IsNullOrWhiteSpace(inputAddLine1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(inputAddLine1, "Cannot leave blank.");
                inputAddLine1.SelectAll();
            }
        }

        //precondition: All fields must pass validation
        //postcondition: closes form and returns OK DialogResult
        private void inputAddLine1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(inputAddLine1, "");
        }

        //precondition: must not be empty or null
        //postcondition: passed validating
        private void inputCity_Validating(object sender, CancelEventArgs e)
        {
            //if null or empty hold focus and show error
            if (string.IsNullOrWhiteSpace(inputCity.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(inputCity, "Cannot leave blank.");
                inputCity.SelectAll();
            }
        }

        //precondition: All fields must pass validation
        //postcondition: closes form and returns OK DialogResult
        private void inputCity_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(inputCity, "");
        }

        //precondition: must not be empty or null
        //postcondition: passed validating
        private void inputStateBox_Validating(object sender, CancelEventArgs e)
        {
            //if null or empty hold focus and show error
            if (string.IsNullOrWhiteSpace(inputStateBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(inputStateBox, "Cannot leave blank.");
            }
        }

        //precondition: All fields must pass validation
        //postcondition: closes form and returns OK DialogResult
        private void inputStateBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(inputStateBox, "");
        }

        //precondition: must not be empty or null, Must be an int, ZIP_MIN <= value <= ZIP_MAX
        //postcondition: passed validating, stores input value into Zip
        private void inputZip_Validating(object sender, CancelEventArgs e)
        {
            //if null or empty hold focus and show error
            if (string.IsNullOrWhiteSpace(inputZip.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(inputZip, "Cannot leave blank.");
                inputZip.SelectAll();
            }
            //if not an int hold focus and show error
            else if (!int.TryParse(inputZip.Text, out int zipResult))
            {
                e.Cancel = true;
                errorProvider1.SetError(inputZip, "Must be numbers.");
                inputZip.SelectAll();
            }
            //if out of predetermined range hold focus and show error
            else if (zipResult < MIN_ZIP || zipResult > MAX_ZIP)
            {
                e.Cancel = true;
                errorProvider1.SetError(inputZip, "Zip must be U.S. 5 digit zip code.");
                inputZip.SelectAll();
            }
            else
                Zip = zipResult;
        }

        //precondition: All fields must pass validation
        //postcondition: closes form and returns OK DialogResult
        private void inputZip_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(inputZip, "");
        }

        //precondition: All fields must pass validation
        //postcondition: closes form and returns OK DialogResult
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        //precondition: Press down Cancel button
        //postcondition: closes form and returns Cancel DialogResult
        private void buttonCancel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        //precondition: Press down clear button
        //postcondition: clears all input data from form
        private void buttonClear_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                inputName.Clear();
                inputAddLine1.Clear();
                inputAddLine2.Clear();
                inputCity.Clear();
                inputStateBox.SelectedIndex = 0;
                inputZip.Clear();
            }
        }
    }
}
