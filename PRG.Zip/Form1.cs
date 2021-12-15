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
            StreamReader sr = FileHelper.OpenFile();
            int[] frequency = Zipper.CalculateFrequency(sr);
            
            Node n;
            for (int i = 0; i < frequency.Length; i++)
                if (frequency[i] != 0)
                    n = Dll.AddInOrder(frequency[i], Convert.ToByte(i));

            Tree.BuildTree();
        }
    }
}