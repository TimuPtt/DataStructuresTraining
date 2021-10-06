using StackSample.Model;
using System;

namespace StackSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new ListStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            var item = stack.Pop();
            var item2 = stack.Peek();

            Console.WriteLine(item);
            Console.WriteLine(item2);
            Console.WriteLine();

            var linkedStack = new LinkedStack<int>();

            linkedStack.Push(10);
            linkedStack.Push(20);
          

            //Console.WriteLine(linkedStack.Peek());
            //Console.WriteLine(linkedStack.Pop());
            //Console.WriteLine(linkedStack.Pop());
            //Console.WriteLine(linkedStack.Peek());

            var arrayStack = new ArrayStack<int>(5);
            Console.WriteLine(arrayStack.Count);
            arrayStack.Push(100);
            Console.WriteLine(arrayStack.Count);
            arrayStack.Push(200);
            arrayStack.Push(300);
            arrayStack.Push(400);
            arrayStack.Push(500);

            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Peek());



            Console.ReadLine();
        }
    }
}
