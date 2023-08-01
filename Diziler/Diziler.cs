using System;
internal class Diziler
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        // Dizileri parçalamak - array slicing
        string[] sehirler = { "istanbul", "ankara", "izmir", "çanakkale", "antalya", "aydın", "muğla", "Bursa" };

        // 0 ile 3 arasınkiler
        foreach(string s in sehirler[0..3])
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("------------------");
        // 5 den sonrakiler
        foreach (string s in sehirler[5..])
        {
            Console.WriteLine(s);
        }
    }

    private static void DiziOrnek2()
    {
        Console.WriteLine("lütfen bir sayi giriniz");
        int x = Convert.ToInt32(Console.ReadLine());

        int[] elemanlar = new int[x];

        var r = new Random();

        for (int i = 0; i < x; i++)
            elemanlar[i] = r.Next(1, 100);
        foreach (var s in elemanlar)
            Console.WriteLine($"{s,5}  karesi {s * s,5} ");
    }

    private static void DizilerOrnek1()
    {
        /* 
         * diziler tanımlandığında bellekte bir yer her bir dizi elemeanı için bir byte ve integer için 4 byte lık
         * bir ayrılır csharp zero base yani sıfır tabanlı olduğu diznin elemanları 0 dan başlar
         * diziller sadece tek boyutta değil çok boyutluda olabilirler
         */


        // tanımlama
        int[] numaralar;

        // başlatlatma
        // dizinin uzunluğunu dinamik bir hale getirmek için 3 olarak belirtmeden [] şeklindede tanımlanabilir.
        numaralar = new int[3];

        // tek satırda hem tanımlama hemde başlatma işlemini gerçekleştirebiliriz.
        // int[] numaralar = new int[3] { 1, 2, 3 };

        numaralar[0] = 3;
        numaralar[1] = 5;
        numaralar[2] = 7;

        for (int i = 0; i < numaralar.Length; i++)
        {
            Console.WriteLine($"numaralar[{i}]= " +
                              $"{numaralar[i]}");
        }
    }
}