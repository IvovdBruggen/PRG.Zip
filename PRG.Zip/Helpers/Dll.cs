using System;

namespace PRG.Zip.Helpers
{
    public class Node
    {
        public Node Previous;
        public Node Next;

        public Node Left;
        public Node Right;

        public int Frequency;
        public byte Value;

        public Node(int frequency, byte value)
        {
            Frequency = frequency;
            Value = value;
        }
    }

    public static class Dll
    {
        public static Node Head;
        public static Node Tail;

        /// <summary>
        /// Add a value to DLL on the correct position(ordered by frequency asc)
        /// </summary>
        /// <algo>
        /// Create new node with given value
        /// Try to add in front of head, after tail or correct position
        /// </algo>
        public static void AddInOrder(int frequency, byte charByte)
        {
            var n = new Node(frequency, charByte);

            if (Head == null)
            {
                Head = n;
                Tail = n;
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
                    if (n.Frequency > Tail.Frequency)
                    {
                        n.Previous = Tail;
                        Tail.Next = n;
                        Tail = n;
                    }
                    else
                    {
                        var tempNode = Tail;

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
        }

        /// <summary>
        /// Add non leaf within the DLL
        /// </summary>
        /// <algo>
        /// Find correct position in terms of frequency and place node
        /// Set head 2 positions forward
        /// </algo>
        public static void AddNonLeaf(Node n)
        {
            if (n.Frequency > Tail.Frequency)
            {
                n.Previous = Tail;
                Tail.Next = n;
                Tail = n;
            }
            else
            {
                var tempNode = Tail;

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


        // /// <summary>
        // /// Read DLL ASC
        // /// </summary>
        // /// <algo>
        // /// 
        // /// </algo>
        // public static void ReadInOrder()
        // {
        //     throw new NotImplementedException();
        // }
    }
}