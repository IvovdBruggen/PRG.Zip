using System.IO;
using System.Windows.Forms;

namespace PRG.Zip.Helpers
{
    public static class FileHelper
    {
        /// <summary>
        /// Return filestream from OpenFileDialog
        /// </summary>
        public static OpenFileDialog OpenFile()
        {
            var dialog = new OpenFileDialog();

            return dialog.ShowDialog() != DialogResult.OK ? null : dialog;
        }

        public static FolderBrowserDialog OpenFolder()
        {
            var dialog = new FolderBrowserDialog();

            return dialog.ShowDialog() != DialogResult.OK ? null : dialog;
        }

        public static void CreateFile(string path, string fileName, string content)
        {
            var file = File.CreateText(path + $"\\{fileName}");
            file.Write(content);
            file.Close();
        }
    }
}