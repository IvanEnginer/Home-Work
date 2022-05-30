using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace work_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            words.Add("One", 1);
            words.Add("Two", 2);
            words.Add("Three", 3);

            Console.WriteLine("Enter word");

            string keyWord = Console.ReadLine();

            if (words.ContainsKey(keyWord))
                Console.WriteLine("Meaning : " + words[keyWord]);
            else
                Console.WriteLine("Fail");

        }
    }
}
