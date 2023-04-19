using System;
internal class ListeUygulamasi
{
    private static void Main(string[] args)
    {
        // basit bir liste tanımlaması yapıldı
        var sehirler = new List<string>()
        {
            "Ankara",
            "İstanbul",
            "Van",
            "Samsun",
            "Ordu"
        };

        /*
        foreach (var s in sehirler)
        {
            Console.WriteLine(s);
            Console.WriteLine("-----------------------");
        }
        */

        // lambda expression
        sehirler.ForEach(s => Console.WriteLine(s));
        //Console.WriteLine(new string('-',50));
        Console.WriteLine(new string('-', 50));


        /* iller değişkenine sehirler değişkenini referans gösteriyoruz iller üzerinden yapılan tüm işlemler
         * aslında sehirler üzerinde yapılmıştır yani iller içinden bir sehir yazdırmak istersek bellekte sehirler in
         * bulunduğu yere gidecek ve oradan getirecek.
         */

        // asıl değerler belleğin HEAP bölümünde tutulur adresler ise STACK bölümünde tutulur.
        var iller = sehirler;
        iller.ForEach(i => Console.WriteLine(i));
        Console.WriteLine(new string('-', 50));

        sehirler.Add("Sinop");
        sehirler.ForEach(s => Console.WriteLine(s));
        Console.WriteLine();

        iller.ForEach(i => Console.WriteLine(i));

        Console.WriteLine(new string('-', 50));

        iller.Remove("Ankara");
        iller.ForEach(iller => Console.WriteLine(iller));
        Console.WriteLine(new string('-', 50));
        sehirler.ForEach(sehirler => Console.WriteLine(sehirler));
        Console.WriteLine(new string('-', 50));


        Console.ReadKey();


    }
}