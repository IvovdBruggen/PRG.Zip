using System;
using System.IO;
using System.Windows.Forms;
using Prg.Zip.Helpers;
using PRG.Zip.Helpers;

namespace PRG.Zip
{
    public partial class Form1 : Form
    {
        private static int _addedBits = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnZip_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = FileHelper.OpenFile();
            FolderBrowserDialog outputFolder = FileHelper.OpenFolder();
            
            string input = new StreamReader(dialog.FileName).ReadToEnd();
            string fileExtension = Path.GetExtension(dialog.FileName);
            
            byte[] frequency = Zipper.CalculateFrequency(input);
            
            Node n;
            for (int i = 0; i < frequency.Length; i++)
                if (frequency[i] != 0)
                    n = Dll.AddInOrder(frequency[i], Convert.ToByte(i));

            Tree.BuildTree();
            Dll.BuildPath(Dll.Head);
            
            var encodedString = Tree.EncodeString(input, Dll.paths);
            while (encodedString.Length % 8 != 0)
            {
                encodedString += '0';
                _addedBits++;
            }

            var fileContents = $"{encodedString} {_addedBits} {fileExtension}";

            var fileName = dialog.SafeFileName.Split('.')[0];
            
            FileHelper.CreateFile(outputFolder.SelectedPath, fileName, fileContents);
        }
    }
}