/* W8172
 * CIS-199-01
 * Lab 7
 * 1 April 2018
 * Windows Forms application that applies the Net Present Value formula from Finance to calculate how much money you need to invest today to earn a certain amount in the future. 
 * Your form will gather inputs for the future value (F), the annual interest rate (r) - expressed as a floating point value (like 0.05 for 5%), and the number of years in the future (n) that interest will compound. 
 * Your application will calculate the present value (P) that you'd need to invest today to earn the desired amount of money in the future.
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

namespace Lab_7
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        /* precondition: positive number value entered into all 3 text boxes, and button clicked. 
         * postcondition: future value is divided by the 1 plus the interest rate raised to the number of years to get the present value needed.
         * Present value is then output to the blank label.
        */
        private void calcButton_Click(object sender, EventArgs e)
        {
            double future;                          //variable that will hold the input value for the future value.
            double rate;                            //variable that will hold the input value for the interest rate.
            int years;                              //variable that will hold the input value for the number of years.    
            double present;                         //variable that will hold the output value for the present value.

            //checks to make sure input is valid and store the proper input into the proper variable.
            if ((double.TryParse(inputFutVal.Text, out future) && future >= 0) 
                && (double.TryParse(inputIntRate.Text, out rate) && rate > 0) 
                && (int.TryParse(inputNumYear.Text, out years) && years >= 0))
            {
                //Method call that stores the returned value into the proper variable.
                present = CalcPresentValue(future, rate, years);

                //outputs the present value as currency to the proper label.
                outputPresentValue.Text = $"{present:c}";
                
            }
            //Displays error message for improper inputs.
            else
                MessageBox.Show("Enter valid numbers!!!");
        }

        /* precondition: 0 <= future amount, 0 < interest rate, and 0 <= number of years. 
         * postcondition: future value is divided by the 1 plus the interest rate raised to the number of years to get the present value needed.
         * Present value is then returned.
        */
        public static double CalcPresentValue(double future, double rate, int years)
        {
            return future / Math.Pow((1 + rate), years);
        }
    }
}
