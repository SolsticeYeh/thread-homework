using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(interesting).Start();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("@");
            }
        }

        static void interesting()
        {
            for (int j = 0; j < 5; j++)
            {
                Thread.Sleep(2000);
                Console.Write("$");
            }
        }
    }
}
