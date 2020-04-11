using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace armstrong_numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Homework homework = new Homework();
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == 13)
            {
                label2.Text = "";
                if (homework.Armstrong(txtNumber.Text.ToString()))
                {
                    label2.Text = "Yes, Armstrong Number";
                    label2.ForeColor = Color.Green;
                    listNumbers.Items.Add("Bingo! A Armstrong Number : " + txtNumber.Text);
                }
                else
                {
                    label2.Text = "No, Not Armstrong Number";
                    label2.ForeColor = Color.Red;
                }
            }
               
        }
    }
}
