using System;
using System.IO;
using System.Windows.Forms;
using Prg.Zip.Helpers;
using PRG.Zip.Helpers;

namespace PRG.Zip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnZip_Click(object sender, EventArgs e)
        {
            Zipper.Zip();
        }
    }
}