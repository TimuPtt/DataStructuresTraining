﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public class LinkedList<T> : IEnumerable
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Clear();
        }

        public LinkedList(T data)
        {
            var item = new Item<T>(data);
            SetHeadTail(item);
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);
            
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadTail(item);
            }
        }
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
        }
        
        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };

            Head = item;
            Count++;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        private void SetHeadTail(Item<T> item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {   
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
