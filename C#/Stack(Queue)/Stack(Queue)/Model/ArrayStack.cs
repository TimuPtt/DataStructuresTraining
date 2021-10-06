﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSample.Model
{
    public class ArrayStack<T>
    {
        T[] items;

        public int Count => current + 1;
        private int current = -1;
        private int size = 10;

        public ArrayStack(int size = 10)
        {
            items = new T[size];
            this.size = size;
        }

        public ArrayStack(T data, int size = 10) : this(size)
        {
            items[current] = data;
            current++;
        }

        public void Push(T data)
        {
            if(current < size - 1)
            {
                current++;
                items[current] = data;
            }
            else
            {
                throw new StackOverflowException();
            }
        }

        public T Pop()
        {
            if (current >= 0)
            {
                var item = items[current];
                current--;
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek()
        {
            if (current >= 0)
            {
                return items[current];
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }
    }
}
