using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab05
{
    class MyCollection<T>
    {
        private T[] array;

        public MyCollection()
        {
            array = new T[0];
        }

        public void Enqueue(T element)
        {
            Array.Resize<T>(ref array, array.Length + 1);
            array[array.Length - 1] = element;
        }
        public T QueuePeek() => array[0];

        public T Dequeue()
        {
            var temp = array[0];
            var tempp = new T[array.Length-1];
            for (int i = 1; i < array.Length; i++) tempp[i - 1] = array[i];
            array = tempp;
            return temp;
        }

        public void Push(T element)
        {
            Array.Resize<T>(ref array, array.Length + 1);
            array[array.Length - 1] = element;
        }
        public T StackPeek() => array[array.Length - 1];

        public T Pop()
        {
            var temp = array[array.Length - 1];
            Array.Resize<T>(ref array, array.Length - 1);
            return temp;
        }

        public List<T> GetList() => array.OfType<T>().ToList();

    }
}
