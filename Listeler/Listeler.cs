using System;
internal class Listeler
{
    private static void Main(string[] args)
    {
        // listeler yer tutucudur ve generic ifade barındırır. içerisindeki ifadelerin tipi çalışma zamanında belirlenir bu da tip güvenliğini sağlar

        /* tanımlama
         * vs2022 versiyonunda zaten genel namespaceler eklendiği için using olarak eklemedik ancak
         * list yapısı tanınmazsa "using System.Collections.Generic;" şeklinde yukarıya ekleyebiliriz
         */
        List<int> sayilar = new List<int>();
        /* liste içerisindeki ifadlerin tiplerine aşağıdaki örnekteki gibi örtülü değişken olarak ta tanımlayabiliriz
         * var sayilar = new List<int>();
         */

        // ekleme
        sayilar.Add(10);
        // tipi int olarak belirlediğimiz için string bir ifade atamayız.
        sayilar.Add(20);
        sayilar.Add(30);
        

        int x = 55;
        sayilar.Add(x);

        int[] seri = new int[] { 70, 90, 100 };

        sayilar.AddRange(seri);

        sayilar.AddRange(new int[] { 11, 22, 33 });
        // insert ile araya eklemede yapılabilir " sayilar.Insert(sonuna eklenecek eleman, eklenecek elemanın kendisi);"
        sayilar.Insert(3, 0);
        sayilar.InsertRange(4, new int[] {999,888,777});

        // dolaşma
        foreach (int i in sayilar)
        {
            Console.WriteLine($"{i,5}");
        }

        foreach (int s in seri)
        {
            Console.WriteLine($"{s,5}");
        }
        

        // listeden eleman çıkartmak
        sayilar.RemoveAt(3); //index nosu 3 olan liste elemanı kaldırılır

        // eğer liste içerisinde bir çok elemean var ve bunların içerisinden istediğimiz elemeanı çıkartmak istiyorsak indexof kullanılabilir.
        sayilar.RemoveAt(sayilar.IndexOf(55));
        Console.WriteLine("--------------------------");

        foreach (int i in sayilar)
        {
            Console.WriteLine($"{i,5}");
        }


        Console.ReadKey();

    }
}