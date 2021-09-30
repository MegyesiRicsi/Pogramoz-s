using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210930
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_szamit_Click(object sender, EventArgs e)
        {
            double szam = int.Parse(txt_szam.Text);
            txt_gyök.Text =Convert.ToString(Math.Round(Math.Sqrt(szam), 4));
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
