using LinkedList.Model;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var circularList = new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);

            foreach(var item in circularList)
            {
                Console.WriteLine(item);
            }

            circularList.Delete(3);
            Console.WriteLine();

            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }

            //var duplexList = new DuplexLinkedList<int>();
            //duplexList.Add(1);
            //duplexList.Add(2);
            //duplexList.Add(3);
            //duplexList.Add(4);
            //duplexList.Add(5);

            //foreach(var item in duplexList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //var reverseList = duplexList.Reverse();

            //foreach (var item in reverseList)
            //{
            //    Console.WriteLine(item);
            //}

            //var list = new Model.LinkedList<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //list.Delete(1);
            //list.Delete(4);

            //list.AppendHead(9);

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            Console.ReadLine();

        }
    }
}
