/*
 * Name:Kirandeep Kaur
 * Student Id: 300915966
 * Date:15/08/2017
 * Description:- Created splashform
 * Version:- 0.4 added form closing event handler
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
/*
 * Name:Kirandeep Kaur
 * Student Id: 300915966
 * Date:15/08/2017
 * Description:- Implement Formula for switching radio and imperial buttons
 * Version:- 0.4 clearing form
 */
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
        /// <summary>
        /// this is a event handler for "tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormtimer_Tick(object sender, EventArgs e)
        {
            BMICalculator Bmicalculator = new BMICalculator();
            Bmicalculator.Show();
            this.Hide();
            SplashFormtimer.Enabled = false;//timer turns off

        }
    }
}
