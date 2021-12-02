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

namespace TesztversenyGUI
{
  /*  class Teszt
    {
        public string nev, valasz;
        public Teszt(string sor)
        {
            var s = sor.Split(' ');
            nev = s[0];
            valasz = s[1];
        }
    }*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*  var sr = new StreamReader("valaszok.txt");
              var lista = new List<Teszt>();
              while (!sr.EndOfStream)
              {
                  lista.Add(new Teszt(sr.ReadLine()));
              }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_beolvas_Click(object sender, EventArgs e)
        {
            var sr = new StreamReader("valaszok.txt");
            var elso = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                listBox1.Items.Add(sr.ReadLine());
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            string nev = txt_nev.Text;
            string valasz = txt_valasz.Text;
            for (int i = 0; i < valasz.Length; i++)
            {
                if (valasz[i]=='a' || valasz[i] == 'b' || valasz[i] == 'c' || valasz[i] == 'd' ||valasz[i] == 'x' )
                {

                }
                else
                {
                    valasz = "";
                    MessageBox.Show("hibák karakterlánc");
                }
            }
            if (nev!="" && valasz!="" && valasz.Length == 14)
            {
                listBox1.Items.Add(nev + " " + valasz);
            }
            else
            {
                MessageBox.Show("hibaás válasz");
            }
        }

        private void Btn_fileba_Click(object sender, EventArgs e)
        {
            var sw =new StreamWriter("adatok.txt");
            if (listBox1.Items.Count!=0)
            {
                foreach (var item in listBox1.Items)
                {
                    sw.WriteLine(item);
                }
            }
            
        }

        private void Btn_kereses_Click(object sender, EventArgs e)
        {
            
            var lista = new List<string>();
          
            if (listBox1.Items.Count!=0)
            {
                foreach (var item in listBox1.Items)
                {
                    if (item.ToString().Contains(txt_nev.Text))
                    {
                        lista.Add(item.ToString());
                    }
                }
                listBox1.Items.Clear();
                foreach (var item in lista)
                {
                    if (item.Contains(txt_nev.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                  
                }
            }
            else
            {
                MessageBox.Show("üres  LISTA");
            }

            
        }
    }
}
