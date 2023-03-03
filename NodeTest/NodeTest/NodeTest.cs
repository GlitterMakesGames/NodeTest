class NodeTest
{
    public static void Main(string[] args)
    {
        Node root = new Node(2);
        Node leaf1 = new Node(1);
        Node leaf2 = new Node(3);

        root.leftChild = leaf1;
        root.rightChild = leaf2;
        leaf1.parent = root;
        leaf2.parent = root;

        Node current = root;
        Console.WriteLine("The priority of the root is " + current.priority);
        current = current.leftChild;
        Console.WriteLine("The priority of the leftmost leaf is " + current.priority);
        current = current.parent.rightChild;
        Console.WriteLine("The priority of the rightmost leaf is "+ current.priority);
    }
}