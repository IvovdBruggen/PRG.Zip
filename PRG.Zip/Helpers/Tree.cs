using System.Collections.Generic;
using System.Linq;

namespace PRG.Zip.Helpers
{
    public static class Tree
    {
        /// <summary>
        /// Create tree with leafs/non-leafs
        /// </summary>
        /// <algo>
        /// Start at head
        /// Combine head frequency and head.Right frequency into new node
        /// Add node to DLL
        /// </algo>
        public static void BuildTree()
        {
            while (Dll.Head.Next != null)
            {
                var n = new Node(Dll.Head.Frequency + Dll.Head.Next.Frequency, 0)
                {
                    Left = Dll.Head,
                    Right = Dll.Head.Next
                };
            
                Dll.AddInOrder(n);
            }
        }
        
        
        /// <summary>
        /// Return encoded string
        /// </summary>
        /// <algo>
        /// Loop through each character in the input and add the according path to output string
        /// </algo>
        public static string EncodeString(string input, Dictionary<byte,string> paths)
        {
            string output = "";
            
            foreach (char c in input)
            {
                output += paths.First(x => x.Key == c).Value;
            }

            return output;
        }
    }
}