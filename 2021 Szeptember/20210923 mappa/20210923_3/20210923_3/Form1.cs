using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210923_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_kor_Click(object sender, EventArgs e)
        {
            
            try
            {
                double adat = double.Parse(txt_adat.Text);
                txt_ker.Text = Convert.ToString(Math.Round(Math.PI * adat * 2, 6));
                txt_ter.Text = Convert.ToString(Math.Round(Math.PI * Math.Pow(adat, 2), 6));
                lbl_ker.Text = "A kör Kerülete";
                lbl_ter.Text = "A köt Területe";
            }
            catch (FormatException)
            {

                MessageBox.Show("Hibás karaktereket adott meg!");
            }
        }

        private void Btn_gomb_Click(object sender, EventArgs e)
        {
            lbl_ker.Text = "A kör Felszine";
            lbl_ter.Text = "A kör Térfogat";
            try
            {
                double adat = double.Parse(txt_adat.Text);
                //Átmérő d = 2 × r
                double d = 2 * adat;
                //Gömb felszíne	P =	π × d² = 4 × π × r²	[m²]
                txt_ker.Text = Convert.ToString(Math.Round( Math.PI * Math.Pow(d, 2), 6));
                //Térfogata	V =	1/6 π × d³ = 4/3 π × r³	[m³]
                txt_ter.Text = Convert.ToString(Math.Round(Math.PI * 1 / 6 * Math.Pow(d, 3)));
            }
            catch (FormatException)
            {

                MessageBox.Show("Hibás karaktereket adott meg!");
            }
            
            

        }
    }
}
