using System;
namespace CustomStack;
class Program{
    public static void Main(string[] args)
    {
        Stack<int> myStack = new Stack<int>();
        myStack.Push(11);
         myStack.Push(12);
          myStack.Push(13);
           myStack.Push(14);
           myStack.Push(15);
            
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
    }
}