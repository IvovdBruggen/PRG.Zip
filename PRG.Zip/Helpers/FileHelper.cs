using System.IO;
using System.Windows.Forms;

namespace PRG.Zip.Helpers
{
    public static class FileHelper
    {
        /// <summary>
        /// Return filestream from OpenFileDialog
        /// </summary>
        public static StreamReader OpenFile()
        {   
            // var file = new OpenFileDialog();
            // file.ShowDialog();
            // return file.ShowDialog() != DialogResult.OK ? null : file.OpenFile();

            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() != DialogResult.OK) return null;
            
            StreamReader stream = File.OpenText(dialog.FileName);
            
            return stream;
        }
    }
}