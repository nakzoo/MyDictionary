using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> StudentandNo = new Dictionary<string, int>();
            StudentandNo.Add("eren oktay",26);
            StudentandNo.Add("Engin Demirog", 35);

            //Öğelere ulaşmak için - 1
            //foreach (var item in StudentandNo)
            //{
            //    Console.WriteLine(item);
            //}

            // Öğelere ulaşmak için -2
            //var items = StudentandNo.OrderBy(i => i.Key);
            //foreach (var item in items)
            //{
            //    Console.WriteLine("Adı >{0} No >{1}", item.Key, item.Value);
            //}





            MyDictionaryy<string, int> myDictionaryy = new MyDictionaryy<string, int>();
            myDictionaryy.Add("Engin Demirog", 45);
            myDictionaryy.Add("Bayram Ozkan", 38);

           
           




        }
    }
}
