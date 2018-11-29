/*
 * Created by: Nice Mena
 * Created on: november 21st 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Percentage Program
 * This program...
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

namespace PercentProgramNiceM
{
    public partial class frmPercentProgram : Form
    {
        public frmPercentProgram()
        {
            InitializeComponent();
        }

        private int ConvertToPercent(string level)
        {
            int percentage = -1;


            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;

            }
            return percentage;


        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            // declaing the variables
            string level;
            int perecentage;

            // gettiing the level
            level = txtGrade.Text;

            // calling the percentage
            perecentage = this.ConvertToPercent(level);

            // display the percentage to the user
            MessageBox.Show("The percentage is " + perecentage + " %");

        }


    }
}
