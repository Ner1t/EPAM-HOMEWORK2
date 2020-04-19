using System;

namespace EVEN_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string a = "EPAMITDAYS";

            for (int i = 1; i < a.Length; i++)

                a = a.Remove(i, 1);

            Console.WriteLine(a);
        }
    }
}
