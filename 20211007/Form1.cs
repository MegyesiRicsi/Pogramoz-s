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

namespace _20211007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txt_nev.Text!="" && txt_szam.Text!="")
            {
                if (File.Exists("tippek.txt"))
                {
                    string osszes = File.ReadAllText("tippek.txt");
                    if (osszes.Contains(txt_nev.Text))
                    {
                        MessageBox.Show("Van már ilyen nevű játékos");
                    }
                    else
                    {


                        string[] beolvas = File.ReadAllLines("tippek.txt");
                        int tippszam = beolvas[0].Trim().Split(' ').Length - 1;
                        int tsz = txt_szam.Text.Trim().Split(' ').Length;
                        if (tippszam == tsz)
                        {
                            File.AppendAllText("tippek.txt", txt_nev.Text + " " + txt_szam.Text + "\n");
                            MessageBox.Show("Az állomány bővitése sikeres volt.");
                        }
                        else
                        {
                            MessageBox.Show("A tippek száma nem megfelőle");
                        }
                    }
                    }
                else
                    {
                        File.AppendAllText("tippek.txt", txt_nev.Text + " " + txt_szam.Text + "\n");
                        MessageBox.Show("Az állomány bővitése sikeres volt.");

                    }
                
            }
            else
            {
                MessageBox.Show("asd");
            }
        }

        private void Txt_szam_TextChanged(object sender, EventArgs e)
        {
            string tartalom = txt_szam.Text.Trim();
            int db = tartalom.Split(' ').Length;
            lbl_db.Text = db + "db";
            


        }
    }
}
