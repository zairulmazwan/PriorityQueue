public class Node 
{
    public String name;
    public int priority;
    public Node next;

    public Node(String name, int priority)
    {
        this.name = name;
        this.priority = priority;
        this.next = null;
    }

    public void printNode()
    {
        Console.Write("Name: "+name+" Priority: "+priority+" ");
    }
}