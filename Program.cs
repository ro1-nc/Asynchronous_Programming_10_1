using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Await_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            Method1();
            Method2();

            Console.ReadKey();
        }
        public static async  void Method1()
        {
            await Task.Run(() =>
            {
                try
                {                  
                    Thread.Sleep(5000);
                    throw new Exception("Own Custom error");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
                

            });

        }

        public static void Method2()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method 2");              
                Thread.Sleep(1000);
            }

        }


    }
}
