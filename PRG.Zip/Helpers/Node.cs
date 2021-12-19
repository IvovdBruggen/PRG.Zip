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
        
        public bool IsLeaf() => Left == null && Right == null;
    }
}