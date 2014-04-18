using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        /// <summary>
        /// This is my awesome thing thingy.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            List<string> myList = new List<string>();
            myList.Add("a string");
            myList.Add("asdfaaddd");
            myList.Add("dumbjdodfen");
            myList.Add("Blufumpkin");
            List<int> numberList = new List<int>();
            numberList.Add(678);
            numberList.Add(789);



            var mySplit = "this text is split".Split(' ').ToList();
            foreach (string s in myList)
            {
                Console.WriteLine(s);
                foreach(
            }
            Console.ReadKey();
        }
    }
}
