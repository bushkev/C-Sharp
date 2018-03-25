/* W8172
 * Problem 2
 * 6 March 2018
 * Cis-199-01
 * a Windows Forms GUI application that will determine the earliest time that a continuing UofL undergraduate student may register for courses using the priority registration schedule
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
using static System.Console;

namespace Problem2
{
    public partial class Problem2 : Form
    {
        public Problem2()
        {
            InitializeComponent();
        }

        //event that occurs once button is pushed.
        private void buttonCal_Click(object sender, EventArgs e)
        {
            char lastName;                                  //variable to hold the input of the letter of last name.
            double hours;                                   //variable to hold the input of the credit hours.

            const double SENIOR = 90;                       //variable to hold the cutoff for seniors. 
            const double JUNIOR = 60;                       //variable to hold the cutoff for juniors.
            const double SOPH = 30;                         //variable to hold the cutoff for sophomores.

            const String TIME_ONE = "8:30 AM";              //variable to hold the output for 1st time.
            const String TIME_TWO = "10:00 AM";             //variable to hold the output for 2nd time.
            const String TIME_THREE = "11:30 AM";           //variable to hold the output for 3rd time.
            const String TIME_FOUR = "2:00 PM";             //variable to hold the output for 4th time.
            const String TIME_FIVE = "4:00 PM";             //variable to hold the output for 5th time.

            const String DATE_SEN = "March 28th";           //variable to hold the output for 1st date.
            const String DATE_JUN = "March 29th";           //variable to hold the output for 2nd date.
            const String DATE_SOPH_A = "March 30th";        //variable to hold the output for 3rd date.
            const String DATE_SOPH_B = "April 2nd";         //variable to hold the output for 4th date.
            const String DATE_FRESH_A = "April 3rd";        //variable to hold the output for 5th date.
            const String DATE_FRESH_B = "April 4th";        //variable to hold the output for 6th date.

            const char GROUP_A_ONE = 'd';                   //variable to hold the cutoff for the first group of last names of seniors and juniors.
            const char GROUP_A_TWO = 'i';                   //variable to hold the cutoff for the second group of last names of seniors and juniors.
            const char GROUP_A_THREE = 'o';                 //variable to hold the cutoff for the third group of last names of seniors and juniors.
            const char GROUP_A_FOUR = 's';                  //variable to hold the cutoff for the forth group of last names of seniors and juniors.

            const char GROUP_B_ONE = 'b';                   //variable to hold the cutoff for the first group of first half of last names of sophomores and freshmen.
            const char GROUP_B_TWO = 'd';                   //variable to hold the cutoff for the second group of first half of last names of sophomores and freshmen.
            const char GROUP_B_THREE = 'f';                 //variable to hold the cutoff for the third group of first half of last names of sophomores and freshmen.
            const char GROUP_B_FOUR = 'i';                  //variable to hold the cutoff for the forth group of first half of last names of sophomores and freshmen.

            const char GROUP_B_HALF = 'l';                  //variable to hold the cutoff for the first half of last names of sophomores and freshmen.

            const char GROUP_C_ONE = 'o';                   //variable to hold the cutoff for the first group of second half of last names of sophomores and freshmen.
            const char GROUP_C_TWO = 'q';                   //variable to hold the cutoff for the second group of second half of last names of sophomores and freshmen.
            const char GROUP_C_THREE = 's';                 //variable to hold the cutoff for the third group of second half of last names of sophomores and freshmen.
            const char GROUP_C_FOUR = 'v';                  //variable to hold the cutoff for the forth group of second half of last names of sophomores and freshmen.


            //checks to see if credit hours input is in proper format.
            if ((double.TryParse(inputGpa.Text, out hours)) && (hours >= 0))
            {
                //checks to see if letter input is in proper format.
                if (char.IsLetter(inputLetter.Text, 0))
                {
                    //takes name and converts it to one lowercase letter and stores into a variable.
                    lastName = char.ToLower(char.Parse(inputLetter.Text.Substring(0, 1)));

                    //seperates juniors and seniors to this if statement.
                    if (hours >= JUNIOR)
                    {
                        //checks for senior or junior and outputs matching date to form.
                        if (hours >= SENIOR)
                            outputDate.Text = $"{DATE_SEN}";
                        else
                            outputDate.Text = $"{DATE_JUN}";

                        //checks letter range and outputs matching time to form.
                        if (lastName <= GROUP_A_ONE)
                            outputTime.Text = $"{TIME_ONE}";
                        else if (lastName <= GROUP_A_TWO)
                            outputTime.Text = $"{TIME_TWO}";
                        else if (lastName <= GROUP_A_THREE)
                            outputTime.Text = $"{TIME_THREE}";
                        else if (lastName <= GROUP_A_FOUR)
                            outputTime.Text = $"{TIME_FOUR}";
                        else
                            outputTime.Text = $"{TIME_FIVE}";
                    }

                    //seperates sophomores and freshmen to this else statement.
                    else
                    {
                        //seperates those with last names starting with L or below to this if statement.
                        if (lastName <= GROUP_B_HALF)
                        {
                            // checks for sophomore or freshmen and outputs matching date to form.
                            if (hours >= SOPH)
                                outputDate.Text = $"{DATE_SOPH_A}";
                            else
                                outputDate.Text = $"{DATE_FRESH_A}";

                            //checks letter range and outputs matching time to form.
                            if (lastName <= GROUP_B_ONE)
                                outputTime.Text = $"{TIME_ONE}";
                            else if (lastName <= GROUP_B_TWO)
                                outputTime.Text = $"{TIME_TWO}";
                            else if (lastName <= GROUP_B_THREE)
                                outputTime.Text = $"{TIME_THREE}";
                            else if (lastName <= GROUP_B_FOUR)
                                outputTime.Text = $"{TIME_FOUR}";
                            else
                                outputTime.Text = $"{TIME_FIVE}";
                        }

                        //seperates those with last names starting with M or above to this else statement.
                        else
                        {
                            // checks for sophomore or freshmen and outputs matching date to form.
                            if (hours >= SOPH)
                                outputDate.Text = $"{DATE_SOPH_B}";
                            else
                                outputDate.Text = $"{DATE_FRESH_B}";

                            //checks letter range and outputs matching time to form.
                            if (lastName <= GROUP_C_ONE)
                                outputTime.Text = $"{TIME_ONE}";
                            else if (lastName <= GROUP_C_TWO)
                                outputTime.Text = $"{TIME_TWO}";
                            else if (lastName <= GROUP_C_THREE)
                                outputTime.Text = $"{TIME_THREE}";
                            else if (lastName <= GROUP_C_FOUR)
                                outputTime.Text = $"{TIME_FOUR}";
                            else
                                outputTime.Text = $"{TIME_FIVE}";
                        }
                    }
                }

                //error message for if letter input is not in proper format.
                else
                    MessageBox.Show("Please enter the correct first letter of your last name.");
            }

            //error message for if credit hours input is not in proper format.
            else
                MessageBox.Show("Please enter your correct credit hours.");

        }
    }
}
