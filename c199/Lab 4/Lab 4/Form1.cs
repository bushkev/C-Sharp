/* W8172
 * 18 Feb 2018
 * CIS-199-01
 * Windows Forms application that make simple admission decisions for a hypothetical university based on the rules given below. 
 * The user enters a numeric high school grade point average and an admission test score, and an answer is given.
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

namespace Lab_4
{
    public partial class AdTestForm : Form
    {
        int accept = 0;                                           //variable to hold running tally of accepted.
        int reject = 0;                                           //variable to hold running tally of rejected.
        public AdTestForm()
        {
            InitializeComponent();
        }

        //Actions taken place upon button click
        private void butCal_Click(object sender, EventArgs e)
        {
            float gpa;                                              //variable to hold gpa value.
            uint test;                                              //variable to hold test score.
            int gpaLow = 0;                                         //variable to hold lowest possible gpa.
            int gpaHi = 3;                                          //variable to hold high gpa cut off.
            int testHi = 80;                                        //variable to hold high test score cut off.
            int testLow = 60;                                       //variable to hold low testscor cut off.

            //checks to see if first input is valid number.
            if ((float.TryParse(inputGpa.Text, out gpa)) && gpa >= gpaLow)
            {
                //checks to see if second input is valid number.
                if (uint.TryParse(inputTest.Text, out test))
                {
                    //checks criteria for acceptance, returns answer, and keeps tally of answers.
                    if (gpa >= gpaHi && test >= testLow)
                    {
                        outputAns.Text = "Accepted";
                        accept++;
                    }
                    else if (gpa >= gpaLow && test >= testHi)
                    {
                        outputAns.Text = "Accepted";
                        accept++;
                    }
                    else
                    {
                        outputAns.Text = "Rejected";
                        reject++;
                    }
                }
                //else from if statement to check second input.
                else
                    MessageBox.Show("Score must be a positive number!");
                    outputAns.Text = " ";                             //clears the textbox when a decision cannot be reached.
            }
            //else from if statement to check first input.
            else
                MessageBox.Show("GPA must be a positive number!");
                outputAns.Text = " ";                             //clears the textbox when a decision cannot be reached.

            //uncomment next line to get accept and reject results.
            //MessageBox.Show($"Accepted: {accept} \nRejected: {reject}");
        }
    }
}
