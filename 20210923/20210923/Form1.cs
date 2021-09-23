using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210923
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Width = this.Width;
            label1.BackColor = Color.Red;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleRight;
        }

        private void Btn_kek_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Blue;
        }

        private void Btn_fekete_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Black;
        }

        private void Btn_barna_Click(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void Btn_kozep_Click(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void Btn_kisbetu_Click(object sender, EventArgs e)
        {
            label1.Text=label1.Text.ToLower();
        }

        private void Btn_nagyb_Click(object sender, EventArgs e)
        {
            label1.Text=label1.Text.ToUpper();
        }

        private void Btn_torol_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void Btn_kiir_Click(object sender, EventArgs e)
        {
            label1.Text = "Házi Feladat";
        }

        private void Btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
