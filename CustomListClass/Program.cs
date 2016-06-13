using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> intSampleList = new CustomList<int>();
            intSampleList.AddToList(5);
            intSampleList.AddToList(15);
            intSampleList.AddToList(25);
            CustomList<string> stringSampleList = new CustomList<string>();
            stringSampleList.AddToList("Adam");
            stringSampleList.AddToList("Andrew");
            stringSampleList.AddToList("Mike");
            intSampleList.PrintList();
            stringSampleList.PrintList();

            Console.WriteLine("Press any key to quit:");
            Console.ReadKey();
        }
    }
}
