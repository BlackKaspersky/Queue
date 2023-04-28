namespace Queue
{
    public  class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.Contain(3));
            Console.WriteLine(queue.Dequeue());
            foreach(var i in queue)
            {
                Console.Write(i + " ");
            }

        }
    }
}