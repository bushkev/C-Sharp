/* W8172
 * Lab 3
 * 11 Feb 2018
 * CIS-199-01
 * a Windows Forms application that calculates and displays several geometric values of a sphere given its radius. 
 * The user will enter the sphere's radius (as a double) and the application will calculate and display the sphere's diameter, surface area, and volume.
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

namespace Lab_3
{
    public partial class GeoValue : Form
    {
        public GeoValue()
        {
            InitializeComponent();
        }

        //Actions performed once the calculate button is pressed.
        private void buttonCal_Click(object sender, EventArgs e)
        {
            double rad;                                 // variable to hold the radius.
            double diam;                                // variable to hold the diameter.
            double surf;                                // variable to hold the surface area.
            double vol;                                 // variable to hold the volume.

            rad = double.Parse(inputRad.Text);          //receive input from user, convert to a double and store in variable.

            //perform conversions and store to the proper variable.
            diam = 2 * rad;
            surf = 4 * Math.PI * Math.Pow(rad, 2);
            vol = (4.0 / 3.0) * Math.PI * Math.Pow(rad, 3);

            //output results to proper labels.
            outputDiam.Text = $"{diam:F2}";
            outputSurf.Text = $"{surf:F2}";
            outputVol.Text = $"{vol:F2}";
        }
    }
}
