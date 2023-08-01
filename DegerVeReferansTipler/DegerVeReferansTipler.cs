using System;
internal class DegerVeReferansTipler
{
    private static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        Console.WriteLine("{0},{1}", x, y);
        Degistir(x,y);
        Console.WriteLine("{0},{1}", x, y);

        Console.WriteLine("---------------------------");

        RefDegistir(ref x,ref y);
        Console.WriteLine("{0},{1}", x, y);
        Console.WriteLine("---------------------------");


        // eğer değişkenin değeri belli değil ise out keyword kullanılabilir ancak out olarak verilen metodun içerisinde
        // bu değeri set etmemiz gereklidir.
        int t;
        OutDegistir(out t);
        Console.WriteLine();
        Console.WriteLine("artık t nin yeni değeri : {0} ",t);


        // nullable types
        // eğer bir tip nullable olabilir ise int? şeklinde tanımlanmalıdır.
        int? maas= null;
        // HasValue eğer değişkenin değeri var true yoksa false döner
        if (maas.HasValue)
        {
            Console.WriteLine("değer var");
        }
        else
        {
            Console.WriteLine("değer yok");
            // eğer içerisindeki değer yok veya null ise uygulama tarafında değeri 0 dır.
            // GetValueOrDefault() eğer değeri varsa değerini getirir null veya değer yok ise sıfır döner.
            Console.WriteLine(maas.GetValueOrDefault());
        }

        Console.ReadLine();

    }




    /* burada yerlerinin değişmesi için bir metod tanımlandı metod çağrıldığında yerler değişir ancak
     * metod dışında yer değişimi olmaz çünkü dışarıdaki main metodu içerisinde deki değişkenleri etkilemez
     * bu tip değişkenlere değer tipli değişkenler denir belleğin heap bölümünde tutulurlar
     */

    private static void Degistir(int a, int b)
    {
        int gecici = a;
        a = b;
        b = gecici;
        Console.WriteLine("{0},{1}",a,b);
    }
    // buradada referans için ref sözcüğünü kullandık ve metod bizim x ve y değişkenlerimizin domain metod içerisinde yerini değiştirecek

    private static void RefDegistir(ref int a, ref int b)
    {
        int gecici = a;
        a = b;
        b = gecici;
        Console.WriteLine("{0},{1}", a, b);
    }

    private static void OutDegistir(out int a)
    {
        a = 11;
        Console.WriteLine( " out olarak verilen t değeri: {0}",a);
    }

}