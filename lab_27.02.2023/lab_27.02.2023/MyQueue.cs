using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class MyQueue<T>
    {
        private List<T> array = new List<T>();

        public void Enqueue(T item)
        {
            array.Add(item);
        }

        public T Dequeue()
        {
            if (array.Count == 0)
            {
                throw new InvalidOperationException("MyQueue is empty");
            }

            T item = array[0];
            array.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            if (array.Count == 0)
            {
                throw new InvalidOperationException("MyQueue is empty");
            }

            return array[0];
        }

        public int Count
        {
            get { return array.Count; }
        }

        public void Clear()
        {
            array.Clear();
        }
    }

}
