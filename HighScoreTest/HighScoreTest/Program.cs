using System;
using System.Collections.Generic;

namespace HighScoreTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //int max = 0, next = 0; 
            var ls = new List<int> { 30, 50, 20, 70 };
            ls.Sort();
            int max = 0;
            int last = ls.Count - 1;
            max = ls[last];
            //foreach (int x in ls)
            //{
            Console.WriteLine(ls);
            //}

            Console.WriteLine("At the end of the file!");
        }
    }
}
