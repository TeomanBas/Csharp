using System;

namespace Operatorler
{
    public class Operatorler
    {
        static void Main(string[] args)
        {
            int A = 20, B= 10;

            // Aritmetik Operatorler
            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A / B);
            Console.WriteLine(A * B);
            Console.WriteLine(A % B);

            Console.WriteLine("--------------------------------------");
            
            // iliskisel operatorler
            Console.WriteLine(A > B);
            Console.WriteLine(A < B);
            Console.WriteLine(A >= B);
            Console.WriteLine(A <= B);
            Console.WriteLine(A == B);
            Console.WriteLine(A != B);

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(!(A > B && A < 5));
            Console.WriteLine(A > B || A < 5);

            Console.ReadLine();


        }
    }

}