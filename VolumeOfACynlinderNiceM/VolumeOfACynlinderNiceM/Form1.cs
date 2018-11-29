/*
 * Created by: Nice Mena
 * Created on: November 23rd 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
 * This program calcu;ates th volume of a cylinder
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

namespace VolumeOfACynlinderNiceM
{
    public partial class frmVolumeOfACynlinder : Form
    {
        public frmVolumeOfACynlinder()
        {
            InitializeComponent();
            this.lblVolume.Hide();
        }

        private double CalculateVolume(double height, double radius)
        {
            // create variable
            double volume;

            // calculating the volume
            volume = Math.PI * Math.Pow(radius, 2) * height;

            // return the volume
            return volume;
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            // declaring ther vaiables
            double userRadius, userHeight, userVolume;

            // converting the strings in the textbox to doubles
            userHeight = double.Parse(txtHeight.Text);
            userRadius = double.Parse(txtRadius.Text);

            // calling the function
            userVolume = CalculateVolume(userHeight, userRadius);

            // rounding the answer
            userVolume = Math.Round(userVolume, 1);

            // displaying the answer
            this.lblVolume.Show();
            this.lblVolume.Text = "The volume is " + userVolume + " cm^3 ";













        }
    }
}
