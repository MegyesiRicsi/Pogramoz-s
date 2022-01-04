using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211021_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_balfent_Click(object sender, EventArgs e)
        {
            this.Top = 100;
            this.Left =100;
        }

        private void Btn_jobbfent_Click(object sender, EventArgs e)
        {
            var szelesseg = this.Width;
            var magassag = this.Height;
            var winszel = Screen.PrimaryScreen.Bounds.Width;
            var winmag = Screen.PrimaryScreen.Bounds.Height;
            var szel = winszel - szelesseg;
            this.Top = 0;
            this.Left = szel;
        }

        private void Btn_ballent_Click(object sender, EventArgs e)
        {
            var szelesseg = this.Width;
            var magassag = this.Height;
            var winszel = Screen.PrimaryScreen.Bounds.Width;
            var winmag = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Btn_jobblent_Click(object sender, EventArgs e)
        {
            var szelesseg = this.Width;
            var magassag = this.Height;
            var winszel = Screen.PrimaryScreen.Bounds.Width;
            var winmag = Screen.PrimaryScreen.Bounds.Height;
        }
    }
}
