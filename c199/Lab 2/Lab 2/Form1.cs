/* W8172
 * Lab 2
 * 4 Feb 2018
 * CIS-199-01
 * Create and test a Windows Forms application that serves as a tip calculator. The user will enter the price of their meal and the application will calculate and display tips for 15%, 18%, and 20%. Specifically, the application must have:
         A Form titled "Lab 2". Remember, the form's Text property controls the information displayed in the form's title bar.
         A Label titled "Enter price of meal:" next to a TextBox that will gather this information from the user.
         Labels for "15%", "18%", and "20%" next to output Labels. Remember, for output labels, you'll need to change the AutoSize and BorderStyle properties (as demonstrated in class).
         A Button titled "Calculate Tip" with an event handler (as in Figure 3-10 of your text) that calculates and displays the three tip amounts using currency formatting. Remember, magic numbers are to be avoided. Use named constants, such as TIPRATE_LOW or TIPRATE1 instead of literals like .15, or .18m, etc. See p. 80-81 of your text for how to do this.
         All controls should be renamed from the defaults (label1, button1, etc.) to have descriptive names.
 * Instead of simply creating labels that are hard-coded to display the percentages in Design view, consider how you might programmatically display the percentages (using your named constants) instead.
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

namespace Lab_2
{
    public partial class Form1 : Form
    {
        const double LOW_TIP = .15; // constant variable for low tip rate.
        const double MID_TIP = .18; // constant variable for middle tip rate.
        const double HIGH_TIP = .20; // constant variable for high tip rate.
        double mealPrice;           // variable for price of meal.
        double lowTipOut;           //Variable for calculation of low tip rate.
        double midTipOut;           //Variable for calculation of middle tip rate.
        double highTipOut;          //Variable for calculation of high tip rate.

        public Form1()
        {
            InitializeComponent();
        }

        //loads the variables for the labels to display on the GUI on launch.
        private void Form1_Load(object sender, EventArgs e)
        {
            labelLowTip.Text = $"{LOW_TIP:P0}";
            labelMidTip.Text = $"{MID_TIP:P0}";
            labelHighTip.Text = $"{HIGH_TIP:P0}";
        }

        //actions performed once the calulate button is pressed.
        private void CalButton_Click(object sender, EventArgs e)
        {
            //price is inputed and stored.
            mealPrice = double.Parse(boxPrice.Text);

            //calculations are performed
            lowTipOut = mealPrice * LOW_TIP;
            midTipOut = mealPrice * MID_TIP;
            highTipOut = mealPrice * HIGH_TIP;

            //calculations are output to the labels on the GUI.
            labelLowOut.Text = $"{lowTipOut:C}";
            labelMidOut.Text = $"{midTipOut:C}";
            labelHighOut.Text = $"{highTipOut:C}";
        }
    }
}
