using lab08lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    


    public static class MageGuildExtensions
    {

        public static void GetMages(this MageGuild mages)
        {
            var temp =
                from m in mages
                where m.Strength > 10
                orderby m.Strength
                select m;
            foreach (var e in temp) Console.WriteLine(e);
        }

        public static void GetMages2(this MageGuild mages) => mages.Where(m => m.Strength > 10)
            .OrderBy(m => m.Strength)
            .ToList()
            .ForEach(m => Console.WriteLine(m));

        public static void GetMages3(this MageGuild mages) => Enumerable.Where(mages, m => m.Strength > 10)
            .OrderBy(m => m.Strength)
            .ToList()
            .ForEach(m => Console.WriteLine(m));

        public static void GetMages4(this MageGuild mages) => mages
            .Where(delegate (Mage m) { return m.Strength > 10; })
            .OrderBy(delegate (Mage m) { return m.Strength; })
            .ToList()
            .ForEach(m => Console.WriteLine(m));

        public static void GetMages5(this MageGuild mages) => mages
            .Where(WhereMethod)
            .OrderBy(OrderByMethod)
            .ToList()
            .ForEach(m => Console.WriteLine(m));

        public static bool WhereMethod(Mage m) => m.Strength > 10;
        public static int OrderByMethod(Mage m) => m.Strength;

        public static void GetMages6(this MageGuild mages)
        {
            List<Mage> temp = new List<Mage>();
            foreach (var mage in mages)
            {
                if (mage.Strength > 10)
                {
                    temp.Add(mage);
                }
            }
            temp.Sort( (m1, m2) => m1.Strength.CompareTo(m2.Strength));
            temp.ForEach(m => Console.WriteLine(m));
        }

    }
}
