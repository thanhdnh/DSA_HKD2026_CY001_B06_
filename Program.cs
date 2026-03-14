public class Node
{
    public object data;
    public Node link;
    public Node(object data)
    {
        this.data = data;
        this.link = null;
    }
    public Node()
    {
        this.data = null;
        this.link = null;
    }
}
public class LinkedList
{
    public Node header;
    public LinkedList(){
        this.header = new Node("Header");
    }
    public Node Find(object value)
    {
        Node current = header;
        while(!current.data.Equals(value))
            current = current.link;
        return current;
    }
    public void Insert(object newdata, object afterelement)
    {
        Node newNode = new Node(newdata);
        Node afterNode = Find(afterelement);
        newNode.link = afterNode.link;
        afterNode.link = newNode;
    }
    public Node FindPrev(object value)
    {
        Node current = header;
        while(!current.link.data.Equals(value))
            current = current.link;
        return current;
    }
    public void Remove(object existeddata)
    {
        Node current = FindPrev(existeddata);
        current.link = current.link.link;
    }
    public void Print()
    {
        Node current = header.link;
        while(current != null)
        {
            Console.Write(current.data + " ");
            current = current.link;
        }
        Console.WriteLine();
    }
    public void AddFirst(object newdata)
    {
        
    }
    public void AddLast(object newdata)
    {
        
    }
    public void AddAfter(object newnode, object afterelement)
    {
        
    }
    public void AddBefore(object newnode, object beforeelement)
    {
        
    }
    public int CountNode()
    {
        Node current = header.link;
        int count = 0;
        while (current != null)
        {
            current = current.link;
            count++;
        }
        return count;
    }
    public int SumNode()
    {
        return 0;
    }
    public void PrintPythagoreTriplet()
    {
        
    }
}
//Xây dựng lại DoubleLinkedList với các phương
//thức tương tự như LinkedList ở trên (singlely)
public class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Insert("5", "Header");
        list.Insert("10", "5");
        list.Insert("15", "10");
        //list.Print();
        //list.Remove("10");
        //list.Print();
        int count = list.CountNode();
        Console.WriteLine($"Count: {count}");
    }
}