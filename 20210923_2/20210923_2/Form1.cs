using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210923_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_ossz_Click(object sender, EventArgs e)
        {
            double adat1=double.Parse(textBox1.Text);
            double adat2 = double.Parse(textBox2.Text);
            lbl_change.Text = "Művelet: Összeadás!";
            double ossz = adat1 + adat2;
            txt_eredmeny.Text = Convert.ToString(ossz);
        }

        private void Btn_kivon_Click(object sender, EventArgs e)
        {
            double adat1 = double.Parse(textBox1.Text);
            double adat2 = double.Parse(textBox2.Text);
            lbl_change.Text = "Művelet: Kivonás!";
            double kulonb = adat1 - adat2;
            txt_eredmeny.Text = Convert.ToString(kulonb);
        }

        private void Bnt_szor_Click(object sender, EventArgs e)
        {
            double adat1 = double.Parse(textBox1.Text);
            double adat2 = double.Parse(textBox2.Text);
            lbl_change.Text = "Művelet: Szorzás!";
            double szor = adat1 * adat2;
            txt_eredmeny.Text = Convert.ToString(szor);
        }
    }
}
