/* W8172
 * lab 6
 * Cis-199-01
 * 25 March 2018
 * Create a GUI application that allows a user to enter a student’s number of words typed. 
 * Make sure the user's input is valid, otherwise prompt them to correct their mistake using a MessageBox. 
 * The output is the letter grade earned by the student. 
 * The design of the application's interface is up to you. 
 * You must use parallel arrays and range matching (not simply a series of if/else if statements)
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

namespace Lab_6
{
    public partial class Lab6 : Form
    {
        public Lab6()
        {
            InitializeComponent();
        }

        //actions performed once button is clicked
        private void calButton_Click(object sender, EventArgs e)
        {
            int amtWords;                                               //int to store input of words typed.
            char grade;                                                 //char to store the grade assigned.
            bool found = false;                                         //bool to keep track of whether or not the range is found.
            int[] wordsArr = {0, 16, 31, 51, 76 };                      //array that holds the lowest number of each range.
            char[] gradeArr = { 'F', 'D', 'C', 'B', 'A' };              //array that holds the letter grade for the corresponding range of the parrallel array.
            int index = wordsArr.Length - 1;                            //int to store the index for the arrays.

            //Checks to make sure a correct input is entered.
            if (int.TryParse(inputWord.Text, out amtWords) && int.Parse(inputWord.Text) >= 0)
            {
                //loops until the correct range is found
                while(!found)
                {
                    //checks to see if input is within the currently checked range. If it is then found bool sets to true ending the loop.
                    if (amtWords >= wordsArr[index])
                        found = true;
                    //If not then index is decremented and loop continues with next range.
                    else
                        index--;
                }

                grade = gradeArr[index];                                //assigns the char found in the array to the char variable.
                outputLabel.Text = $"{grade}";                          //outputs the proper char value to the form.
            }
            //if input is incorrect from user, a message box will popup and tell them.
            else
                MessageBox.Show("You must enter a valid number.");
        }
    }
}
