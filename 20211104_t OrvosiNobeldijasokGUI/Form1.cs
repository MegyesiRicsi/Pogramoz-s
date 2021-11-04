using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _20211104_t_OrvosiNobeldijasokGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_ment_Click(object sender, EventArgs e)
        {
            
                int ev = int.Parse(txt_ev.Text);
                string nev = txt_nev.Text;
                string szh = txt_szh.Text;
                string kod = txt_orszag.Text;

                if (txt_ev.Text == "" && txt_nev.Text == "" && txt_orszag.Text == "" && txt_szh.Text == "")
                {
                    MessageBox.Show("Töltösn ki minden mezőt!!!!!!!!!");
                }
                else
                {
                    if (ev > 1989)
                    {

                        try
                        {
                        File.AppendAllText("uj_dijazott.txt", "Év;Nén;SzületésHalálozás;Országkód\r");
                            string szo = txt_ev.Text + ";" + txt_nev.Text + ";" + txt_szh.Text + ";" + txt_orszag.Text;
                        File.AppendAllText("uj_dijazott.txt", szo+"\r");
                        txt_ev.Text = "";
                        txt_nev.Text = "";
                        txt_orszag.Text = "";
                        txt_szh.Text = "";
                            
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Hiba az állomány irásánlá!");
                        }
                   

                        }
                    else
                    {
                        MessageBox.Show("„Hiba! Az évszám nem megfelelő!");
                    }
                }
            
            
            
            
        }
    }
}
