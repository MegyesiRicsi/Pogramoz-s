using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210930_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_szamit_Click(object sender, EventArgs e)
        {
            int f1 = 1;
            int f2 = 1;
            int f3 = 0;
            string asd = "";
            for (int i = 0; i < 11; i++)
            {
                f3 = f1 + f2;
                asd =asd+ Convert.ToString(f1) + "\n";
                f1 = f2;
                f2 = f3;
            }
            lbl_szam.Text = asd;
            
        }
    }
}
