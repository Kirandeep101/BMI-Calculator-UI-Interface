/*
 * Name:Kirandeep Kaur
 * Student Id: 300915966
 * Date:15/08/2017
 * Description:- Implement Formula for switching radio and imperial buttons
 * Version:- 0.5 finally calculate bmi 
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
    public partial class BMICalculator : Form
    {
        double h;
        double w;
        double calculation;

        public BMICalculator()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            Heighttext.Clear();
            weighttextBox.Clear();
           
            Resulttext.BackColor = Color.LightBlue;

        }

        private void BMIbutton_Click(object sender, EventArgs e)
        {
            BMIbutton.BackColor = Color.LightGreen;
            Resulttext.BackColor = Color.LightBlue;
            h = Double.Parse(Heighttext.Text);
            w = Double.Parse(weighttextBox.Text);


            if (ImperialButton.Checked)
            {

                calculation = (w * 703) / (h * h);
                string Result = Convert.ToString(Math.Round(calculation, 2));
                if (calculation < 18.5)
                { Resulttext.Text = Result; }
                else if (calculation > 18.5 &&calculation < 24.9)
                { Resulttext.Text = Result; }
                else if (calculation> 25 && calculation<= 29.9)
                { Resulttext.Text = Result; }
                else if (calculation >= 30)
                { Resulttext.Text = Result; }
            }
            else if (MetricButton.Checked)
            {
                calculation = w / (h * h);
                string Result = Convert.ToString((calculation));
                 if (calculation < 18.5)
                { Resulttext.Text = Result; }
                else if (calculation > 18.5 &&calculation < 24.9)
                { Resulttext.Text = Result; }
                else if (calculation> 25 && calculation<= 29.9)
                { Resulttext.Text = Result; }
                else if (calculation >= 30)
                { Resulttext.Text = Result; }

            }
        }

        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            meterlabel.Text = "lbs";
            kiloglabel.Text = "inches";
        }

        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            meterlabel.Text = "m";
            kiloglabel.Text = "kg";
        }
    }
}
