using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211014_dolgozat
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

        private void Btn_szamol_Click(object sender, EventArgs e)
        {
            try
            {

                double r = double.Parse(txt_r.Text);
                double m = double.Parse(txt_m.Text);
                if (r > 0 && m > 0)
                {
                   
                    double V = Math.Round(Math.Pow(r, 2) * Math.PI * m, 3);//Térfogat
                    double A = Math.Round(2 * r * Math.PI * (r + m), 3);//Felszin
                    txt_felsz.Text = V + " ";
                    txt_terf.Text = A + "";
                }
                else
                {
                    MessageBox.Show("Eggyik szám se lehet kissebb 0 nál!");
                }


            }
            
            catch (FormatException)
            {

                MessageBox.Show("Nem számot adtál meg vagy nem adtál meg semmit!");
            }
            
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            txt_felsz.Text = "";
            txt_m.Text = "";
            txt_r.Text = "";
            txt_terf.Text = "";
        }

        
    }
}
