using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D3_Training_Ses1
{

    //public delegate void someDel(int a);
    //public delegate void del1();
    //public delegate void del2(int a);
    public delegate void del3(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = (str) =>
            {
                if (str.Length > 10)
                {
                    return true;
                }

                return false;
            };

            Predicate<int> predicate1 = (a) =>
            {
                if (a < 0)
                {
                    return true;
                }

                return false;
            };


            Console.WriteLine(predicate("str"));
            Console.WriteLine(predicate("This is a string"));
            Console.WriteLine(predicate1(9));
            Console.ReadLine();

        }

        public static int sum(int a, int b)
        {
            return a + b;
        }

        public static int returnConstantValue()
        {
            return 100;
        }

    }
}

    //    

    //try
    //{
    //    Console.WriteLine("Write a emailID");
    //    var usrEmail = Console.ReadLine();
    //    validateEmail(usrEmail);
    //}

    //catch (Exception ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}

    //Console.ReadLine();

    //}

    //static void validateEmail(string a)

    //{
    //    Regex regex = new Regex
    //    try
    //    {
    //        Method2(a);
    //    }

    //    catch (Exception ex)
    //    {
    //        Console.WriteLine("exception caught in method1");
    //        throw;
    //    }
    //}

    //static void Method2(int a)
    //{
    //    try
    //    {
    //        var res = a / 0;

    //    }

    //    catch (Exception ex)
    //    {
    //        throw;
    //    }
    //}

    //}


    //class Program
    //{
    //    public event EventHandler someEvent;
    //    static void Main(string[] args)
    //    {

    //    }
    //}










