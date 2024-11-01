PriorityQueue pq = new PriorityQueue();

// Node n1 = new Node("job 1", 2);
// Node n2 = new Node("job 2", 3);
// Node n3 = new Node("job 3", 5);
// Node n4 = new Node("job 4", 3);
// Node n5 = new Node("job 5", 7);
// Node n6 = new Node("job 6", 1);
// Node n7 = new Node("job 7", 7);


// pq.enqueue(n1);
// pq.enqueue(n2);
// pq.enqueue(n3);
// pq.enqueue(n4);
// pq.enqueue(n5);
// pq.enqueue(n6);
// pq.enqueue(n7);

// pq.printQueue();
// Console.WriteLine("\nLength "+pq.length);

// Node x = pq.getNode("job 7");
// pq.dequeue(x);
// pq.printQueue();
// Console.WriteLine("\nLength "+pq.length);



// This is for testing purposes to ensure the algorithm is robust
for (int i = 0; i<6; i++)
{
    Random r = new Random();
    int priority = r.Next(1,12);
    Node n = new Node("Job_"+(i+1), priority);
    pq.enqueue(n);
}

pq.printQueue();
Console.WriteLine("\nLength : "+pq.length);

Node x = pq.getNode("Job_3");
Node y = pq.getNode("Job_1");
pq.dequeue(x);
pq.dequeue(y);
pq.printQueue();
Console.WriteLine("\nLength : "+pq.length);
