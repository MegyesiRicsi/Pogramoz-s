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

namespace _20211007_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_fel_Click(object sender, EventArgs e)
        {
            string[] beolvas = File.ReadAllLines("gyumolcsok.txt");
            foreach (string item in beolvas)
            {
                listBox1.Items.Add(item);
            }
        }

        private void Btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
