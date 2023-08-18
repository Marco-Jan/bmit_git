using System;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int mass = Convert.ToInt32(txtkg.Text);

            double height = Convert.ToInt32(txtcm.Text);

            double newBmi = mass / (height * height) * 10000;
            lbloutput.Text = Convert.ToString(newBmi);

            if (newBmi > 30)
            {
                massSizeop.Text = "Adipositas";
            }
            else if (newBmi > 25)
            {
                massSizeop.Text = "Übergewicht";

            }
            else if (newBmi > 18.5)
            {
                massSizeop.Text = "Normalgewicht";

            }
            else
            {
                massSizeop.Text = "Untergewicht";
            }
        }
    }
}
