using System;
internal class Cevrimler
{
    private static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= y; j++)
            {
                Console.Write("{0,0},{1,0}",i,j + " | ");
            }
            Console.WriteLine("-");
        }

        Console.ReadKey();
    }

    private static void DonguForOrnek()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            if (i % 3 == 0)
            {
                // continue o andaki komutların atlanıp döngünün en başına geri dönülmesini sağlar
                continue;
            }

            if (i == 1000)
            {
                // break döngüyü kırar ve döngüden çıkar
                break;
            }
            Console.Write("{0,5}", i);
        }
    }

    private static void DonguDoWhile()
    {
        Console.WriteLine("lütfen bir sayi giriniz");
        int a = Convert.ToInt32(Console.ReadLine());
        int n = 0;
        do
        {
            Console.Write("{0,5}", a);
            a *= 2;
            n++;
        } while (n < 5);
    }

    private static void DonguWhile()
    {
        int i = 0;
        int sayac = 1;
        while (i < 10)
        {
            // sayac ++; veya sayac =sayac +1; veya sayac +=1; 
            sayac++;
            /* Console.WriteLine(sayac);
             * {0,20} ifadesi ile 20 space lik boşluk bıraktık ve sonra gelen değişken yazıldı - ile sola hizalanır
             * {0.20} ifadesinde 0 sayaca karşılık gelir sıradaki sıfırıncı değişken sayac tır eğer 1 yaparsak sayacın yanındaki 
             * değişkeni de kullanabiliriiz
             */
            Console.WriteLine("DONGU BLOGU!" + "{0,20} " + " karesi " + "{1,05}", sayac, sayac * sayac);
            i++;
        }

        Console.WriteLine("DONGU SONU");
    }
}