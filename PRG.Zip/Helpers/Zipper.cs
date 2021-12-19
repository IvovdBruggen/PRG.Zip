using System;
using PRG.Zip.Helpers;

namespace Prg.Zip.Helpers
{
    public static class Zipper
    {
        /// <summary>
        /// Calculate how many times each byte is in file
        /// </summary>
        /// <algo>
        /// Create a byte array for 256 different chars(includes all symbols)
        /// As long as there are characters in the string, up the frequency for that char
        /// Return byte[]
        /// </algo>
        public static byte[] CalculateFrequency(string file)
        {
            byte[] temp = new byte[256];

            foreach (int c in file)
            {
                temp[c] += 1;
            }

            return temp;
        }
    }
}