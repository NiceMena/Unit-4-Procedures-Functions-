/*
 * Created by: Nice Mena
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Address Program
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

namespace OptionalParametersNiceM
{
    public partial class frmOptionalParameters : Form
    {
        public frmOptionalParameters()
        {
            InitializeComponent();
        }


      
        public void PrintAdress(String street, String city, String province, String postalCode, String aptNum)
        {
            MessageBox.Show("Your adress is: " + street  + ", " + city + ", " + province + ", " + postalCode + " " + "apt #", aptNum + " ");

        }

        public void PrintAdress(String street, String city, String province, String postalCode)
        {
            MessageBox.Show("Your adress is: " + street + " " + city + " " + province + " " + postalCode + " ");

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // declare local variables
            String userStreet, userCity, userProvince, userPostalCode, userAptNum;

            // get the names from the textboxes
            userStreet = this.txtStreet.Text;
            userCity = this.txtCity.Text;
            userProvince = this.txtProvince.Text;
            userPostalCode = this.txtPostalCode.Text;
            userAptNum = this.txtAptNum.Text;

            // get the user to enter a street adress
            if (userStreet == "")
            {
                MessageBox.Show("Please enter your street adress.", "Full Name Program");
            }
            // make the user enter a city
            else if (userCity == "")
            {
                MessageBox.Show("Please enter your city.", "Full Name Program");
            }
        
            // make the user enter a province
            else if (userProvince == "")
            {
                MessageBox.Show("Please enter your province.", "Full Name Program");
            }

            // make the user enter a postal code
            else if (userPostalCode == "")
            {
                MessageBox.Show("Please enter your postal code.", "Full Name Program");
            }

            // make the user a province
            else if (userAptNum == "")
            {
                PrintAdress(userStreet, userCity, userProvince, userPostalCode);
            }
            else 
            {
                PrintAdress(userStreet, userCity, userProvince, userPostalCode, userAptNum);
            }
           




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
