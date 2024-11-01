public class PriorityQueue
{
    Node head;
    Node tail;
    public int length = 0;
    public PriorityQueue()
    {
        head = null;
        tail = null;
    }

    public void enqueue(Node n)
    {
        if (head == null)
        {
            head = n;
            tail = n;
            length++;
        }
        else if (n.priority > head.priority)
        {
            Node temp = head;
            head = n;
            head.next = temp;
            length++;
        }
        else if (n.priority <= tail.priority)
        {
            Node temp = tail;
            tail = n;
            temp.next = n;
            length++;
        }
        else
        {
            Node current = head;
            while (n.priority <= current.priority && current.next != null)
            {
                current.printNode();
                Node next = current.next;
                if (n.priority <= current.priority && n.priority > next.priority)
                {
                    Node temp = next;
                    current.next = n;
                    n.next = temp;
                }
                current = next;
            }
            length++;
        }
    }

    public Node getNode (String name)
    {
        Node res = null;
        if (head == null)
        {
            Console.WriteLine("Empty queue");
        }
        if (head.name == name)
        {
            res = head;
        }
        if (tail.name == name)
        {
            res = tail;
        }
        else
        {
            Node current = head;
            while(current.next != null)
            {
                if (current.name == name)
                {
                    res = current;
                }
                current = current.next;
            }
        }
        return res;
    }

    public void dequeue(Node n)
    {
        if (length == 0)
        {
            Console.WriteLine("The queue is empty");
        }
        if (n == head)
        {
            Node temp = head.next;
            head = temp;
            length--;
        }
        if (n == tail)
        {
            Node current = head;
            for (int i = 0; i < length-2; i++)
            {
                 current = current.next;
            }
           current.next = null;
           tail = current;
           length--;
        } 
        else
        {
            Node current = head;
            while (current.next != null)
            {
                if(n == current.next)
                {
                    Node temp = current.next.next;
                    current.next = temp;
                    length--;
                }
                current = current.next;
            }
        }
    }

    public void printQueue ()
    {
        Console.WriteLine();
        if (head != null)
        {
            Node current = head;
            while(current.next != null)
            {
                current.printNode();
                Console.Write(" ==> ");
                current = current.next;
            }
            current.printNode();
        }
        else
        {
            Console.WriteLine("The queue is empty");
        }
    }
   
}