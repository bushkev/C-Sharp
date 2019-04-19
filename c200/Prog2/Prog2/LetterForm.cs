/*Grading ID: D9689
 * Cis200-01
 * Program 2
 * Due Date: 10/24/2018
 * A form to take user input for creating a letter.
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
using UPVApp;

namespace Prog2
{
    public partial class LetterForm : Form
    {
        string nL = Environment.NewLine;        //shortcut for new line.
        List<Address> incomingAddList;// = new List<Address>();

        //precondition: none
        //postcondition: initializes form
        public LetterForm()
        {
            InitializeComponent();
        }

        //precondition: none
        //postcondition: initializes form and instantiates a List of addresses with the parameters received
        public LetterForm(List<Address> addresses)
        {
            InitializeComponent();
            incomingAddList = addresses;
        }

        internal int OriginAddIndex { get => (originDropDown.SelectedIndex); }      //getter for the origin address indexed selected
        internal int DestAddIndex { get => (destDropDown.SelectedIndex); }          //getter for the destination address indexed selected
        internal decimal Cost { get; set; }                                         //auto henerated getter and setter for the cost

        //precondition: none
        //postcondition: Prepopulates letter and address information to form comboboxes.
        private void LetterForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < incomingAddList.Count; i++)
            {
                originDropDown.Items.Add(incomingAddList[i].Name);
                destDropDown.Items.Add(incomingAddList[i].Name);
            }
        }

        //precondition: Click Cancel button
        //postcondition: closes form and returns Cancel DialogResult
        private void buttonCancel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            this.DialogResult = DialogResult.Cancel;
        }

        //precondition: All fields must pass validation
        //postcondition: closes form and returns OK DialogResult
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            this.DialogResult = DialogResult.OK;
        }
        
        //precondition: must be a decimal value, value >= 0
        //Postcondition: Cost is set to value
        private void inputCost_Validating(object sender, CancelEventArgs e)
        {
            //checks if decimal
            if (!decimal.TryParse(inputCost.Text, out decimal costNum))
            {
                errorProvider1.SetError(inputCost, "Must enter a number.");
                e.Cancel = true;
            }
            //checks if non-negative
            else if (costNum < 0)
            {
                errorProvider1.SetError(inputCost, "Cost must not be negative.");
                e.Cancel = true;
            }
            else
                Cost = costNum;

        }

        //precondition: passed validating
        //postcondition: clears error message
        private void inputCost_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(inputCost, "");
        }

        //precondition: must not be empty or null
        //postcondition: passed validating
        private void originDropDown_Validating(object sender, CancelEventArgs e)
        {
            //if null or empty hold focus and show error
            if(string.IsNullOrWhiteSpace(originDropDown.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(originDropDown, "must choose a value.");
            }
        }

        //precondition: passed validating
        //postcondition: clears error message
        private void originDropDown_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(originDropDown, "");
        }

        //precondition: must not be emptyor null, must not be the same as origin address
        //postcondition: passed validating
        private void destDropDown_Validating(object sender, CancelEventArgs e)
        {
            //if null or empty hold focus and show error
            if (string.IsNullOrWhiteSpace(destDropDown.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(destDropDown, "must choose a value.");
            }
            //if same as origin address hold focus and show error
            else if (originDropDown.Text == destDropDown.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(destDropDown, "Origin and destination must be different.");
            }
        }

        //precondition: passed validating
        //postcondition: clears error message
        private void destDropDown_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(destDropDown, "");
        }
    }
}
