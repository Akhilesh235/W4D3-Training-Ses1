using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D3_Training_Ses1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Method1(4);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception caught");
            }

            Console.ReadLine();

        }

        static void Method1(int a)

        {
            try
            {
                Method2(a);
            }

            catch (Exception ex)
            {
                Console.WriteLine("exception caught in method1");
                throw;
            }
        }

        static void Method2(int a)
        {
            try
            {
                var res = a / 0;

            }

            catch (Exception ex)
            {
                throw;
            }
        }
        
    }
}
