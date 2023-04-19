using System;

namespace YorumRefactoringEscapeOrnekleri
{
    internal class YorumRefactoringEscapeOrnek
    {
        static void Main(string[] args)
        {

            YorumRefactoringEscapeIfadeleri();


        }


        // aşağıda bir refactoring ornegi
        private static void YorumRefactoringEscapeIfadeleri()
        {
            //refactoring olan metodu çağıralım
            //DegiskenOrnekleri2();

            /*
             * aşağıda "\n" şeklinde kullanılan ifade escape ifadesidir \n ifadesi new line anlamına gelir
             * "\t" ifadesi tab tuşu anlamına gelir tab tuşu kadar boşluk bırakır
             * "\a" ifadesi ise bir uyarı tonu çalar
             */
            string ifade = " Csharp\n \tProgramlama\n \t\tTemelleri\n\a ";
            Console.WriteLine(ifade);
            // eğer ters slash "\" ifadesini kullanacaksak bunu iki defa tekrar ettiğimizde kaçış ifadesinden kaçabiliriz
            string dizin = "C:\\user\\Pc";
            Console.WriteLine(dizin);
            // ters slash kullanmak istemiyorsa "@" işaretiyle çıktıyı string olarak almış oluruz.
            string dizin2 = @"C:\user\Pc";
            Console.WriteLine(dizin2);
        }



    }

}
