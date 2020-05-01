using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab05
{
    static class StaticClass
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        public static void GetStates<T, Y>(ref T a, ref Y b)
        {
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine("Typ pierwszego argumentu: " + a.GetType());
            Console.WriteLine("Typ drugiego argumentu: " + b.GetType());
            
            a = default(T);
            b = default(Y);
        }

        public static T GetNewObject<T>() where T : new() => new T();

        public static T GetGreaterObject<T>(T a, T b) where T : IComparable
        {
            if (a.CompareTo(b) >= 0)
            {
                return a;
            }
            else return b;
        }

        public static List<T> GetSortedList<T>(params T[] args)
        {
            List<T> list = new List<T>(args);
            list.Sort();
            return list;
        }

        public static IDictionary<K, V> GetDictionary<K, V>(K key, V value) where K : struct where V : class
        {
            IDictionary<K, V> dic = new Dictionary<K, V>();
            dic.Add(new KeyValuePair<K, V>(key, value));
            return dic;
        }

        public static void GetDictionaryValues<K, V>(IDictionary<K, V> dic)
        {
            foreach (var d in dic) Console.WriteLine($"Klucz: {d.Key}, Wartosc: {d.Value}");
        }

        public static IEnumerable<T> GetQueueOrStack<T>(params T[] args)
        {
            if (args.Length < 3)
            {
                Queue<T> qu = new Queue<T>(args);
                return  qu;
            }
            else
            {
                Stack<T> st = new Stack<T>(args);
                return  st;
            }
        }
    }
}
