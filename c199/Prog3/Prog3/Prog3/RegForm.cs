/* Program 3
 * cis 199-01
 * 29 march 2018
 * W8172
 * this application calculates the earliest registration date
 * and time for an undergraduate student given their class standing and last name.
 * decisions based on uofl summer/fall 2018 priority registration schedule.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        // Find and display earliest registration time
        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            const string DAY1 = "March 28"; // 1st day of registration
            const string DAY2 = "March 29"; // 2nd day of registration
            const string DAY3 = "March 30"; // 3rd day of registration
            const string DAY4 = "April 2";  // 4th day of registration
            const string DAY5 = "April 3";  // 5th day of registration
            const string DAY6 = "April 4";  // 6th day of registration

            const string TIME1 = "8:30 AM";  // 1st time block
            const string TIME2 = "10:00 AM"; // 2nd time block
            const string TIME3 = "11:30 AM"; // 3rd time block
            const string TIME4 = "2:00 PM";  // 4th time block
            const string TIME5 = "4:00 PM";  // 5th time block

            const float SOPHOMORE = 30; // Hours needed to be sophomore
            const float JUNIOR = 60;    // Hours needed to be junior
            const float SENIOR = 90;    // Hours needed to be senior

            string lastNameStr;         // Entered last name
            char lastNameLetterCh;      // First letter of last name, as char
            string dateStr = "Error";   // Holds date of registration
            string timeStr = "Error";   // Holds time of registration
            float creditHours;          // Previously earned credit hours
            bool isUpperClass;          // Upperclass or not?
            bool found = false;         // Is proper range found or not?
            char[] lettersA = {'A', 'E', 'J', 'P', 'T' };               // Array that holds lower letter of range for 1st set.
            char[] lettersB = {'A', 'C', 'E', 'G', 'J' };               // Array that holds lower letter of range for 2nd set.
            char[] lettersC = {'M', 'P', 'R', 'T', 'W' };               // Array that holds lower letter of range for 3rd set.
            String[] times = { TIME1, TIME2, TIME3, TIME4, TIME5};      // Array that holds times for all sets.
            int index = times.Length - 1;                               // variable to hold the index for the arrays.

            lastNameStr = lastNameTxt.Text;
            if (lastNameStr.Length > 0) // Empty string?
            {
                lastNameLetterCh = lastNameStr[0];   // First char of last name
                lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                if (float.TryParse(creditHoursTxt.Text, out creditHours) && creditHours >= 0)
                {
                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        isUpperClass = (creditHours >= JUNIOR);

                        // Juniors and Seniors share same schedule but different days
                        if (isUpperClass)
                        {
                            if (creditHours >= SENIOR)
                                dateStr = DAY1;
                            else // Must be juniors
                                dateStr = DAY2;
                            // Finds correct letter range.
                            while (!found)
                            {
                                if (lastNameLetterCh >= lettersA[index])
                                    found = true;
                                else
                                    index--;
                            }
                            // Sets correct time to string variable.
                            timeStr = times[index];
                        }
                        // Sophomores and Freshmen
                        else // Must be soph/fresh
                        {
                            if (creditHours >= SOPHOMORE)
                            {
                                // A-L on day one
                                if ((lastNameLetterCh <= 'L'))   // <= L
                                {
                                    dateStr = DAY3;
                                    // Finds correct letter range.
                                    while (!found)
                                    {
                                        if (lastNameLetterCh >= lettersB[index])
                                            found = true;
                                        else
                                            index--;
                                    }
                                    // Sets correct time to string variable.
                                    timeStr = times[index];
                                }
                                else // All other letters on next day
                                {
                                    dateStr = DAY4;
                                    // Finds correct letter range.
                                    while (!found)
                                    {
                                        if (lastNameLetterCh >= lettersC[index])
                                            found = true;
                                        else
                                            index--;
                                    }
                                    // Sets correct time to string variable.
                                    timeStr = times[index];
                                }
                    }
                            else // must be freshman
                            {
                                // A-L on day one
                                if ((lastNameLetterCh <= 'L'))   // <= L
                                {
                                    dateStr = DAY5;
                                    // Finds correct letter range.
                                    while (!found)
                                    {
                                        if (lastNameLetterCh >= lettersB[index])
                                            found = true;
                                        else
                                            index--;
                                    }
                                    // Sets correct time to string variable.
                                    timeStr = times[index];
                                }
                                else // All other letters on next day
                                {
                                    dateStr = DAY6;
                                    // Finds correct letter range.
                                    while (!found)
                                    {
                                        if (lastNameLetterCh >= lettersC[index])
                                            found = true;
                                        else
                                            index--;
                                    }
                                    // Sets correct time to string variable.
                                    timeStr = times[index];
                                }

                            }
                        }

                        // Output results
                        dateTimeLbl.Text = dateStr + " at " + timeStr;
                    }
                    else // Not A-Z
                        MessageBox.Show("Make sure last name starts with a letter!");
                }
                else
                    MessageBox.Show("Enter a valid number of credit hours!");
            }
            else // Empty textbox
                MessageBox.Show("Please enter last name!");
        }
    }
}
