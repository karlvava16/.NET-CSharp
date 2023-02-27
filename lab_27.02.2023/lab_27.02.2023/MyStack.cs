using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{

    public class MyStack<T>
    {
        private List<T> array = new List<T>();

        public void Push(T item)
        {
            array.Add(item);
        }

        public T Pop()
        {
            if (array.Count == 0)
            {
                throw new InvalidOperationException("MyStack is empty");
            }

            T item = array[array.Count - 1];
            array.RemoveAt(array.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (array.Count == 0)
            {
                throw new InvalidOperationException("MyStack is empty");
            }

            return array[array.Count - 1];
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
