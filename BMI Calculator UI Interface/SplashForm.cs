
 /*
 * Name:Kirandeep Kaur
 * Student Id: 300915966
 * Date:15/08/2017
 * Description:-  * Version:- 0.5 Adding background picture and welcome sign
 * Version:- 0.5 background image
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

namespace BMI_Calculator_UI_Interface
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormtimer_Tick(object sender, EventArgs e)
        {
            BMICalculator bmiCalculator = new BMICalculator();
            bmiCalculator.Show();
            this.Hide();
            SplashFormtimer.Enabled = false;

        }
    }
}
