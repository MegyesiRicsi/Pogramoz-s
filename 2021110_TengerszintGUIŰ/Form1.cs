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

namespace _2021110_TengerszintGUIŰ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMent_Click(object sender, EventArgs e)
        {
            if (txtOrszag.Text!=""  && txtCucs.Text!="" && txtMag.Text!="")
            {
                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    string kiir = txtOrszag.Text + ";" + txtCucs.Text + ";" + txtMag.Text;
                    File.AppendAllText(saveFileDialog1.FileName, kiir);
                    MessageBox.Show("Sikerült a mentés");
                    txtCucs.Text = "";
                    txtMag.Text = "";
                    txtOrszag.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Nem adtál meg értéket ", "Hiba");
            }
        }

        private void BtnKilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnFel_Click(object sender, EventArgs e)
        {
            var beolvas = File.ReadAllLines("tengerszint.txt", Encoding.Default);
            string[] db;
            foreach (var item in beolvas)
            {
                db = item.Split('\t');
                if (!listBox1.Items.Contains(db[1]))
                {
                    listBox1.Items.Add(db[1]);
                }
                
            }
            
        }

        private void BtnTorol_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem==("Floppa"))
            {
                pictureBox1.Image = ("a.jpg");
            }
        }
    }
}
