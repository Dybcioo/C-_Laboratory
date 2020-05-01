using System;
using System.Collections.Generic;

namespace lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<int> lab = new MyCollection<int>();
            lab.Enqueue(1);
            lab.Enqueue(2);
            lab.Enqueue(3);
            lab.Enqueue(4);

            lab.Pop();
            lab.Dequeue();
            lab.Push(4);
            Console.WriteLine("Wypisanie kolekcji:");
            lab.GetList().ForEach(i => Console.WriteLine(i));
           /* 
            lab.Dequeue();
            Console.WriteLine("Wypisanie kolekcji po usunieciu pierwszego elementu:");
            lab.GetList().ForEach(i => Console.WriteLine(i));
   
            Console.WriteLine("Element ze stosu: "+lab.StackPeek());
            int a = 1;
            int b = 2;
            StaticClass.Swap(ref a, ref b);
            var nowy = StaticClass.GetNewObject<int>();
            Console.WriteLine(a + " " + b + " " + nowy);

            List<MyGenericClass<int, int, int, int>> list = new List<MyGenericClass<int, int, int, int>>();
            list.Add(new MyGenericClass<int, int, int, int>(1, 2, 3, 4));
            list.Add(new MyGenericClass<int, int, int, int>(5, 2, 3, 4));
            list.Add(new MyGenericClass<int, int, int, int>(6, 2, 3, 4));
            list.Add(new MyGenericClass<int, int, int, int>(1, 2, 3, 4));
            list.Add(new MyGenericClass<int, int, int, int>(7, 2, 3, 4));
            list.Sort();
            foreach (var fourValueClass in list)
            {
                Console.WriteLine(fourValueClass.Id);
            }
            int c = 3;
            string d= "kaczka";
            StaticClass.GetStates(ref c, ref d);
            Console.WriteLine(c + " " + d);
            IEnumerable<int> i =   StaticClass.GetQueueOrStack(1, 2);
            Console.WriteLine(i.GetType());*/
        }
    }
}
