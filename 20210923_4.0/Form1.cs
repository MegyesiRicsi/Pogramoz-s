using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210923_4._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_rendez_Click(object sender, EventArgs e)
        {
            int szam1 = int.Parse(txt_1.Text);
            int szam2 = int.Parse(txt_2.Text);
            int szam3 = int.Parse(txt_3.Text);
            List<int> sor = new List<int>();
            sor.Add(szam1);
            sor.Add(szam2);
            sor.Add(szam3);
            sor.Reverse();
            for (int i = 0; i < sor.Count; i++)
            {
                if (i==0)
                {
                    txt_1.Text = Convert.ToString(sor[0]);
                }
                else if (i==1)
                {
                    txt_2.Text = Convert.ToString(sor[1]);
                }
                else if (i==2)
                {
                    txt_3.Text = Convert.ToString(sor[2]);
                }
            }
        }
    }
}
