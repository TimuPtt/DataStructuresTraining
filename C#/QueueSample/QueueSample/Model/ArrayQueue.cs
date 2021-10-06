using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSample.Model
{
    class ArrayQueue<T>
    {
        private T[] items;
        private T Head => items[Count - 1];
        private T Tail => items[0];

        public int Count { get; private set; }

        public EasyQueue() { }

        public EasyQueue(T data)
        {
            items.Add(data);
        }

        public void Enqueue(T data)
        {
            items.Insert(0, data);
        }

        public T Dequeue()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }

        public T Peek()
        {
            return Head;
        }
    }
}
