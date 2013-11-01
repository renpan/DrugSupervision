using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrugSupervise.Library;

namespace DrugSupervise.Test
{
    class Program
    {
        static DrugPacks packs;// = new DrugPack(3, new PackRate("1:2:10"));
        static void Main(string[] args)
        {
            packs = new DrugPacks( new PackRate("1:2:10"));
            Console.WriteLine(packs.PackRate);
            Console.WriteLine(packs.PackRate[0].ToString());
            Console.WriteLine(packs.PackRate[1].ToString());
            Console.WriteLine(packs.PackRate[2].ToString());
            Console.ReadKey();
            packs.Add(0, new DrugBox("000", 0));
            packs.Add(0, new DrugBox("000", 0));
            packs.Add(0, new DrugBox("000", 0));
            packs.Add(0, new DrugBox("000", 0));
            packs.Add(0, new DrugBox("000", 0));
            packs.Add(0, new DrugBox("000", 0));
            packs.Add(0, new DrugBox("000", 0));
            packs.Add(0, new DrugBox("000", 0));
            packs.Add(0, new DrugBox("000", 0));
            packs.Add(0, new DrugBox("000", 0));
            packs.Add(0, new DrugBox("000", 0));




        }
    }
}
