using System;
using System.IO;
using PRG.Zip.Helpers;

namespace Prg.Zip.Helpers
{
    public static class Zipper
    {
        /// <summary>
        /// Zip a file
        /// </summary>
        /// <algo>
        /// Open file to zip
        /// Calculate the frequency of each character
        /// Create a node with Frequency and according character
        /// Create tree out of nodes
        /// </algo>
        public static void Zip(StreamReader file)
        {
            Node n;
            int[] frequencyTable = CalculateFrequency(file);

            for (int i = 0; i < frequencyTable.Length; i++)
                if (frequencyTable[i] != 0)
                    n = Dll.AddInOrder(frequencyTable[i], Convert.ToByte(i));

            Tree.BuildTree();
        }

        /// <summary>
        /// Calculate how many times each byte is in file
        /// </summary>
        /// <algo>
        /// Create a byte array for 255 different chars(includes all symbols)
        /// As long as there are characters in the string, up the frequency for that char
        /// Return byte[]
        /// </algo>
        public static int[] CalculateFrequency(StreamReader file)
        {
            int[] temp = new int[256];
            int tempChar = file.Read();
            
            while (tempChar != -1)
            {
                temp[tempChar] += 1;
                tempChar = file.Read();
            }

            return temp;
        }
    }
}