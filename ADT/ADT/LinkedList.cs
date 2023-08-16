using System.Security.Cryptography.X509Certificates;

namespace ADT
{
    public class LinkedList
    {
        private Node node = new Node();
        private Node head;

        private int count = 0;
        public int Count
        {
            get { return count; }
        }

        private class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }

            public override string ToString()
            {
                return Data.ToString();
            }
        }

        public void InsertAt(int index, object data)
        {
            
        }

        public void DeleteAt(int index)
        {

        }

        public object ItemAt(int index)
        {
            return null;
        }
        public override string ToString()
        {
            return node.ToString();
        }
    }
}