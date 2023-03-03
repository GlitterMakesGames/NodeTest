class Node
{
    private Node? _parent;
    private Node? _leftChild;
    private Node? _rightChild;
    private int _priority;

    public Node parent { get => get(in _parent); set => set(out _parent, in value); }
    public Node leftChild { get => get(in _leftChild); set => set(out _leftChild, in value); }
    public Node rightChild { get => get(in _rightChild); set => set(out _rightChild, in value); }
    public int priority { get => this._priority; set => _priority = value; }

    public Node(int p)
    {
        _priority = p;
    }

    public Node get(in Node getBacking)
    {
        return getBacking;
    }

    public void set(out Node setBacking, in Node newRef)
    {
        setBacking = newRef;
    }
}