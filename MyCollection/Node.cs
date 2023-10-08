namespace MyCollection;

public class Node <T> 
{
    public T Data { get; internal set; }
    public Node<T> Next { get; internal set; }

    public Node(T data)
    {
        Data = data;
    }
}