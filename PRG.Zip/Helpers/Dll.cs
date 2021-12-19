using System;
using System.Collections.Generic;

namespace PRG.Zip.Helpers
{
    public static class Dll
    {
        private const char Left = '1';
        private const char Right = '0';

        public static Dictionary<byte, string> paths = new Dictionary<byte, string>();

        public static Node Head;
        private static Node _tail;

        /// <summary>
        /// Add a value to DLL on the correct position(ordered by frequency asc)
        /// </summary>
        /// <algo>
        /// Create new node with given value
        /// Try to add in front of head, after tail or correct position
        /// </algo>
        public static Node AddInOrder(int frequency, byte charByte)
        {
            var n = new Node(frequency, charByte);

            if (Head == null)
            {
                Head = n;
                _tail = n;
            }
            else
            {
                if (n.Frequency <= Head.Frequency)
                {
                    n.Next = Head;
                    Head.Previous = n;
                    Head = n;
                }
                else
                {
                    if (n.Frequency > _tail.Frequency)
                    {
                        n.Previous = _tail;
                        _tail.Next = n;
                        _tail = n;
                    }
                    else
                    {
                        var tempNode = _tail;

                        while (tempNode.Frequency >= n.Frequency)
                        {
                            tempNode = tempNode.Previous;
                        }

                        n.Previous = tempNode;
                        n.Next = tempNode.Previous;
                        n.Previous.Next = n;
                        n.Next.Previous = n;
                    }
                }
            }

            return Head;
        }

        /// <summary>
        /// Add node within the DLL
        /// </summary>
        /// <algo>
        /// Find correct position in terms of frequency and place node
        /// Set head 2 positions forward
        /// </algo>
        public static void AddInOrder(Node n)
        {
            if (n.Frequency > _tail.Frequency)
            {
                n.Previous = _tail;
                _tail.Next = n;
                _tail = n;
            }
            else
            {
                var tempNode = _tail;

                while (tempNode.Frequency >= n.Frequency)
                {
                    tempNode = tempNode.Previous;
                }

                n.Previous = tempNode;
                n.Next = tempNode.Next;
                n.Previous.Next = n;
                n.Next.Previous = n;
            }


            Head = Head.Next.Next;
        }

        /// <summary>
        /// Fill associative array with respective paths in tree
        /// </summary>
        /// <algo>
        /// Find leafs in tree recursively, add leaf path to path dictionary
        /// </algo>
        public static void BuildPath(Node n, string currentPath = "")
        {
            if (n.IsLeaf())
                paths.Add(n.Value, currentPath);
            
            else
            {
                if (n.Left != null)
                    BuildPath(n.Left, currentPath + Left);
                if(n.Right != null)
                    BuildPath(n.Right, currentPath + Right);
            }
        }
    }
}