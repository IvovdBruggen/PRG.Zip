namespace PRG.Zip.Helpers
{
    public static class Tree
    {
        private const char Left = '1';
        private const char Right = '0';
        
        /// <summary>
        /// Create tree with leafs/non-leafs
        /// </summary>
        /// <algo>
        /// Start at head
        /// Combine head frequency and head.Right frequency into new node
        /// 
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
            
                Dll.AddNonLeaf(n);
            }
        }

        public static void StoreTree()
        {
            string tree = "";

            var tempNode = Dll.Head;
            
            if (!IsLeaf(tempNode))
            {
                
            }
        }

        private static bool IsLeaf(Node n) => n.Left != null || n.Right != null;
    }
}