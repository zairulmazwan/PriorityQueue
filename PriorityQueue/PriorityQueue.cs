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

    public void enqueue(Node n) // To enqueue, we pass an object as node 
    {
        if (head == null) // If the head is null, the queue is empty. Thus, we set the node as the head straight away
        {
            head = n;
            tail = n;
            length++;
        }
        else if (n.priority > head.priority) // If n i higher priority than the head, we set n as the head
        {
            Node temp = head; // Getting the current head as temporary
            head = n; // Set n as the new head
            head.next = temp; // Point the hew head to the previous head
            length++; // Increment the queue's length
        }
        else if (n.priority <= tail.priority) // If n is less or equal priority than the tail
        {
            Node temp = tail; // Get the current tail as temporary
            tail = n; // Set n as the new tail
            temp.next = n; // Set the previous tail as the second last node in the queue
            length++; // Increment the queue's length
        }
        else
        {
            Node current = head; // Set the head as the current node for traversal purposes
            while (n.priority <= current.priority && current.next != null) // While not till the end of the queue and n i less priority than the current node
            {
                Node next = current.next; // Get the next node from current
                if (n.priority <= current.priority && n.priority > next.priority) // If n is less priority than current and higher priority than next
                {
                    Node temp = next; // Get the next as temporary
                    current.next = n; // Point the current next to n
                    n.next = temp; // Point n next to temporary 
                }
                current = next; // If still not found, move current to the next node in the queue
            }
            length++; // Increment the queue's length
        }
    }

    public Node getNode (String name) // This method is used to get the node, for the dequeue purpose
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

    public void dequeue(Node n) // To dequeue, we pass an object as node 
    {
        if (length == 0) //Another way to check the queue is empty, using the length
        {
            Console.WriteLine("The queue is empty");
        }
        if (n == head) // If the node is the head we delete the node straight away
        {
            Node temp = head.next;
            head = temp;
            length--;
        }
        if (n == tail) // If the node is the tail we delete the node straight away
        {
            Node current = head;
            for (int i = 0; i < length-2; i++) // Another way to get the tail using a for loop since we know the length
            {
                 current = current.next;
            }
           current.next = null; //Set the "next" value for the node before the tail as null
           tail = current; // Now set the node as the tail
           length--;
        } 
        else
        {
            Node current = head;
            while (current.next != null) // We traverse until the 2nd last node from the queue
            {
                if(n == current.next) // If the node to be deleted is in the next position from current
                {
                    Node temp = current.next.next; // We can skip 2 node from the current node. Get that node and assign to temp
                    current.next = temp; // Set the current node pointing to temp
                    length--;
                }
                current = current.next; // If still not found, move current to the next node in the queue
            }
        }
    }

    public void printQueue ()
    {
        Console.WriteLine();
        if (head != null)
        {
            Node current = head;
            while(current.next != null) // We traverse until the second last node in the queue 
            {
                current.printNode(); // Printing the node
                Console.Write(" ==> ");
                current = current.next; // Go to the next node
            }
            current.printNode(); // Printing the final node in the queue
        } 
        else
        {
            Console.WriteLine("The queue is empty");
        }
    }
   
}