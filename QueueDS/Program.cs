using System;
namespace QueueDS;
class Program{
    public static void Main(string[] args)
    {
        CustomQueue<int> myQueue = new CustomQueue<int>();
        myQueue.Enqueue(11);
        myQueue.Enqueue(12);
        myQueue.Enqueue(13);
        myQueue.Enqueue(14);
        myQueue.Enqueue(15);
        foreach(int value in myQueue){
            Console.WriteLine("value"+value);
        }
        Console.WriteLine("Before Peek");
        Console.WriteLine(myQueue.Peek());
        Console.WriteLine(myQueue.Peek());
        Console.WriteLine(myQueue.Dequeue());
        Console.WriteLine(myQueue.Dequeue());
        foreach(int value in myQueue){
            Console.WriteLine("value"+value);
        }
        Console.WriteLine("After 2 Dequeue");
        Console.WriteLine(myQueue.Dequeue());
        Console.WriteLine(myQueue.Dequeue());
        Console.WriteLine(myQueue.Dequeue());
        foreach(int value in myQueue){
            Console.WriteLine("value"+value);
        }
    }
}