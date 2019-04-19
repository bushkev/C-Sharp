/*Grading ID: D9689
 * Cis200-01
 * Program 2
 * Due Date: 10/24/2018
 * A simple GUI that will serve as a front end for an application similar to MyUPS.
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
using Prog2;

namespace UPVApp
{
    public partial class mainForm : Form
    {
        string nL = Environment.NewLine;                        //shortcut for new line.
        UserParcelView formObject = new UserParcelView();       //instanciation of UserParcelView class

        //precondition: none
        //postcondition: initializes GUI
        public mainForm()
        {
            InitializeComponent();
        }

        //precondition: none.
        //postcondition: preloads test information into program.
        private void mainForm_Load(object sender, EventArgs e)
        {
            formObject.AddAddress("John Smith", "123 Any St.", "Apt. 45", "Louisville", "KY", 40202);          // Test Address 1
            formObject.AddAddress("Jane Doe", "987 Main St.", "Beverly Hills", "CA", 90210);                   // Test Address 2
            formObject.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321", "El Paso", "TX", 79901);   // Test Address 3
            formObject.AddAddress("John Crichton", "678 Pau Place", "Apt. 7", "Portland", "ME", 04101);        // Test Address 4
            formObject.AddAddress("Tim Jones", "865 Good Music Drive", "Nashville", "TN", 37027);              // Test Address 5
            formObject.AddAddress("Jonny Banana", "942 Private Beach Drive", "Clearwater", "FL", 33755);       // Test Address 6
            formObject.AddAddress("Juan Martinez", "15946 Big Hat Lane", "Apt. 5B", "Austin", "TX", 73344);    // Test Address 7
            formObject.AddAddress("Frank Chowder", "321 Too Cold Way", "Manchester", "NH", 03107);             // Test Address 8

            formObject.AddLetter(formObject.AddressAt(0), formObject.AddressAt(5), 3.95M);                      //test Letter parcel
            formObject.AddLetter(formObject.AddressAt(2), formObject.AddressAt(7), 5.25M);                      //test Letter parcel
            formObject.AddLetter(formObject.AddressAt(4), formObject.AddressAt(1), 0.55M);                      //test Letter parcel

            formObject.AddGroundPackage(formObject.AddressAt(3), formObject.AddressAt(7), 23, 12, 10, 45);      //test groundPackag parcel
            formObject.AddGroundPackage(formObject.AddressAt(6), formObject.AddressAt(1), 5, 25, 30, 15);       //test groundPackag parcel
            formObject.AddGroundPackage(formObject.AddressAt(5), formObject.AddressAt(5), 15, 35, 40, 75);      //test groundPackag parcel
    
        }

        //precondition: click about tab
        //Post condition: Shows a message box containing project information.
        private void aboutSub_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Grading ID: D9689{nL}Section: Cis200-01{nL}Assignment: Program 2{nL}Due Date: 10/24/2018{nL}" +
                            "Description: A simple GUI that will serve as a front end for an application similar to MyUPS.");
        }

        //precondition: click exit tab
        //Post condition: Exits the application
        private void exitSub_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //precondition: click Insert/address tab
        //Post condition: opens new form to take user input for the address and return it, then stores it.
        private void addressSub_Click(object sender, EventArgs e)
        {
            DialogResult result;                                // DailogResult variable declared.
            AddressForm newAddress = new AddressForm();         //instance of AddressForm instantiated

            result = newAddress.ShowDialog();

            //if statement that stores address info if OK button was clicked.
            if(result == DialogResult.OK)
            {
                string name = newAddress.NameLine;              //new string variable to hold name
                string add1 = newAddress.AddLine1;              //new string variable to hold address line 1
                string add2 = newAddress.AddLine2;              //new string variable to hold address line 2
                string city = newAddress.City;                  //new string variable to hold city
                string state = newAddress.State;                //new string variable to hold state
                int zip = newAddress.Zip;                       //new int variable to hold zip code

                formObject.AddAddress(name, add1, add2, city, state, zip);
            }
        }

        //precondition: click Insert/letter tab
        //postcondition: opens new form to take user input for the letter and return it, then stores it.
        private void letterSub_Click(object sender, EventArgs e)
        {
            DialogResult results;                                               // DialogResult variable declared
            LetterForm newLetter = new LetterForm(formObject.AddressList);      // instance of letterForm instantiated

            results = newLetter.ShowDialog();

            //if statement that stores letter info if OK button was clicked.
            if (results == DialogResult.OK)
            {
                int originAddIndex = newLetter.OriginAddIndex;                  //int variable to store the index of address chosen
                int destAddIndex = newLetter.DestAddIndex;                      //int variable to store the index of address chosen
                decimal cost = newLetter.Cost;                                  //decimal variable to store the cost input

                formObject.AddLetter(formObject.AddressAt(originAddIndex), formObject.AddressAt(destAddIndex), cost);
            }
        }

        //precondition: click Result/Letter tab
        //postcondition: displays all addresses to the textbox
        private void addressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();          //clears info currently in textbox

            StringBuilder sb = new StringBuilder();             //stringbuilder variable instantiated

            sb.Append($"{formObject}");
            for (int i = 0; i < formObject.AddressList.Count ; i++)     //for loop add letter info to stringbuilder variable
            {
                sb.Append($"------------------------------{nL}{formObject.AddressList[i]}{nL}");
            }
            outputTextBox.Text = sb.ToString();                         //display stringbuilder to textbox
            
        }

        //precondition: click Result/Parcel tab
        //postcondition: displays all Parcels to the textbox
        private void parcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();          //clears info currently in textbox

            StringBuilder sb = new StringBuilder();             //stringbuilder variable instantiated
            sb.Append($"{formObject}");
            for (int i = 0; i < formObject.ParcelList.Count; i++)     //for loop add letter info to stringbuilder variable
            {
                sb.Append($"------------------------------{nL}{formObject.ParcelList[i]}{nL}");
            }
            outputTextBox.Text = sb.ToString();                         //display stringbuilder to textbox
        }
    }
}
