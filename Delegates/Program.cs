using System;

namespace Delegates
{
    public class Program
    {

        public static void PrintUpper(string str)
        {
         Console.WriteLine(str.ToUpper());   
        }
        public static void PrintLower(string str)
        {
         Console.WriteLine(str.ToLower());   
        }


        private static void Main(string[] args)
        {
            StringerBell mcnulty = null;
            Joiner joiner = new("== The Wire ==");
            mcnulty += PrintUpper;
            mcnulty += PrintLower;
            mcnulty += joiner.JoinAndPrint;

            mcnulty.Invoke("uwu");
        }
    }
}
