/*
 * Name:-Kirandeep Kaur
 * Date:- 4/july/2017
 * Version:- 0.3 UI BMI Calculator
 * Description:- Add github link
 * https://github.com/Kirandeep101/BMI-Calculator-UI-Interface
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator_UI_Interface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
