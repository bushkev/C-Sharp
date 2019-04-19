// Program 3
// CIS 200-01
// Fall 2018
// Due: 12 November 2018
// By: D9689

// File: Prog2Form.cs
// This class creates the main GUI for Program 3. It provides a
// File menu with Open, SaveAs, About and Exit items, an Insert menu with Address and
// Letter items, and a Report menu with List Addresses and List Parcels
// items.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private BinaryFormatter formatter = new BinaryFormatter();  // binary formater to serialize upv data
        private FileStream upvFile;                                 // filestream for upv data                
                
        private UserParcelView upv; // The UserParcelView

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display.
        public Prog2Form()
        {
            InitializeComponent();            
        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // Newline shorthand

            MessageBox.Show($"Program 3{NL}By: D9689{NL}CIS 200{NL}Fall 2018",
                "About Program 3");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Insert, Address menu item activated
        // Postcondition: The Address dialog box is displayed. If data entered
        //                are OK, an Address is created and added to the list
        //                of addresses
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();    // The address dialog box form
            DialogResult result = addressForm.ShowDialog(); // Show form as dialog and store result
            int zip; // Address zip code

            if (result == DialogResult.OK) // Only add if OK
            {
                if (int.TryParse(addressForm.ZipText, out zip))
                {
                    upv.AddAddress(addressForm.AddressName, addressForm.Address1,
                        addressForm.Address2, addressForm.City, addressForm.State,
                        zip); // Use form's properties to create address
                }
                else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
                }
            }

            addressForm.Dispose(); // Best practice for dialog boxes
                                   // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Addresses menu item activated
        // Postcondition: The list of addresses is displayed in the addressResultsTxt
        //                text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Addresses:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Address a in upv.AddressList)
            {
                result.Append(a.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
            }

            reportTxt.Text = result.ToString();

            // -- OR --
            // Not using StringBuilder, just use TextBox directly

            //reportTxt.Clear();
            //reportTxt.AppendText("Addresses:");
            //reportTxt.AppendText(NL); // Remember, \n doesn't always work in GUIs
            //reportTxt.AppendText(NL);

            //foreach (Address a in upv.AddressList)
            //{
            //    reportTxt.AppendText(a.ToString());
            //    reportTxt.AppendText(NL);
            //    reportTxt.AppendText("------------------------------");
            //    reportTxt.AppendText(NL);
            //}

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        // Precondition:  Insert, Letter menu item activated
        // Postcondition: The Letter dialog box is displayed. If data entered
        //                are OK, a Letter is created and added to the list
        //                of parcels
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm; // The letter dialog box form
            DialogResult result;   // The result of showing form as dialog
            decimal fixedCost;     // The letter's cost

            if (upv.AddressCount < LetterForm.MIN_ADDRESSES) // Make sure we have enough addresses
            {
                MessageBox.Show("Need " + LetterForm.MIN_ADDRESSES + " addresses to create letter!",
                    "Addresses Error");
                return; // Exit now since can't create valid letter
            }

            letterForm = new LetterForm(upv.AddressList); // Send list of addresses
            result = letterForm.ShowDialog();

            if (result == DialogResult.OK) // Only add if OK
            {
                if (decimal.TryParse(letterForm.FixedCostText, out fixedCost))
                {
                    // For this to work, LetterForm's combo boxes need to be in same
                    // order as upv's AddressList
                    upv.AddLetter(upv.AddressAt(letterForm.OriginAddressIndex),
                        upv.AddressAt(letterForm.DestinationAddressIndex),
                        fixedCost); // Letter to be inserted
                }
               else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Letter Validation!", "Validation Error");
                }
            }

            letterForm.Dispose(); // Best practice for dialog boxes
                                  // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: The list of parcels is displayed in the parcelResultsTxt
        //                text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            decimal totalCost = 0;                      // Running total of parcel shipping costs
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Parcels:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Parcel p in upv.ParcelList)
            {
                result.Append(p.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
                totalCost += p.CalcCost();
            }

            result.Append(NL);
            result.Append($"Total Cost: {totalCost:C}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        // Precondition:  none
        // Postcondition: Opens a file to use with program
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult results;   // The result of showing form as dialog
            string fileName;        // The string to hold the file name

            //using block to select file
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                fileChooser.CheckFileExists = false;

                results = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (results == DialogResult.OK) // If OK, attempt to deserialize opened file
            {
                //if null or empty display error message
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //try to read and deserialize info from file
                    try
                    {
                        upvFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                        upv = (UserParcelView) formatter.Deserialize(upvFile);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SerializationException)
                    {
                        MessageBox.Show("Error reading from file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        upvFile.Close();
                    }
                }
            }
        }

        // Precondition:  none
        // Postcondition: Saves the file the program was using
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult results;   // The result of showing form as dialog
            string fileName;        // The string to hold the file name

            //using block to enter name to save as
            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;

                results = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (results == DialogResult.OK)  // If OK, attempt to serialize and write info to file
            {
                //if null or empty display error message
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //try to serialize info and write to file
                    try
                    {
                        upvFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                        formatter.Serialize(upvFile, upv);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch(SerializationException)
                    {
                        MessageBox.Show("Error writing to file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        upvFile.Close();
                    }
                }
            }
        }

        // Precondition:  upv item activated
        // Postcondition: The selected address info is replaced with modified info.
        private void addressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = new DialogResult();                 // The result of showing form as dialog
            DialogResult result2 = new DialogResult();                 // The result of showing form as dialog
            EditAddress editForm = new EditAddress(upv.AddressList);   // The edit address dialog box form
            AddressForm editAdd = new AddressForm();                   // the address dialog box form

            result1 = editForm.ShowDialog();

            if (result1 == DialogResult.OK) // Only add if OK
            {
                //loads information from address selected into form
                Address address = upv.AddressAt(editForm.SelectedIndex);
                editAdd.AddressName = address.Name;
                editAdd.Address1 = address.Address1;
                editAdd.Address2 = address.Address2;
                editAdd.City = address.City;
                editAdd.State = address.State;
                editAdd.ZipText = (address.Zip).ToString();

                result2 = editAdd.ShowDialog();

                if (result2 == DialogResult.OK) // Only change if OK
                {
                    //replaces infomation in upv with those entered into form
                    address.Name = editAdd.AddressName;
                    address.Address1 = editAdd.Address1;
                    address.Address2 = editAdd.Address2;
                    address.City = editAdd.City;
                    address.State = editAdd.State;
                    address.Zip = int.Parse(editAdd.ZipText);

                    reportTxt.Clear();      // clears info in report text box
                }
            }
        }
    }
}