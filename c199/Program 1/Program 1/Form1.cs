/*W8172
 * Problem 1
 * 13 Feb 2018
 * CIS-199-01
 * An interactive Windows Forms application that will calculate the number of gallons of paint needed to paint the walls in a room.
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

namespace Program_1
{
    public partial class PaintForm : Form
    {
        public PaintForm()
        {
            InitializeComponent();
        }

        //actions that occur upon click of button
        private void butCal_Click(object sender, EventArgs e)
        {
            double length;           //variable for total lengths of walls.
            double height;           //variable for height of walls.
            int doors;               //variable for amount of doors.
            int windows;             //variable for amount of windows.
            int coats;               //variable for number of coats.
            double cost;             //variable for cost of paint per gallon.
            double area;             //variable for the total paintable area.
            double doorArea = 20;    //variable for area of door.
            double winArea = 15;     //variable for area if window.
            double canArea = 375;    //variable for coverage of a gallon.
            double minAmt;           //variable for minimum amount of paint needed.
            int trueAmt;             //variable for number of gallons one must buy.
            double totCost;          //variable for total cost of paint to purchase.

            //receiving input and storing it to variable.
            length = double.Parse(inputWallLen.Text);
            height = double.Parse(inputWallHeight.Text);
            doors = int.Parse(inputDoor.Text);
            windows = int.Parse(inputWin.Text);
            coats = int.Parse(inputCoat.Text);
            cost = double.Parse(inputCost.Text);

            //calculations done here.
            area = (length * height - ((doors * doorArea) + (windows * winArea))) * coats;
            minAmt = area / canArea;
            trueAmt = (int)Math.Ceiling(minAmt);
            totCost = trueAmt * cost;

            //variables output to form here.
            outputMinAmt.Text = $"{minAmt:F1}";
            outputTrueAmt.Text = $"{trueAmt}";
            outputTotCost.Text = $"{totCost:c}";
        }
    }
}
