using System;

internal class Metodlar
{
    private static void Main(string[] args)
    {
        /*
         * erişim belirteci : public internal protect private ...
         * public : herkes erişebilir.
         * dönüş tipi : void (geriye değer döndürmez)          
         * static : herhangi bir nesneye ihtiyaç duyulmadan ilgili metodun çalışmasına olanak sağlar
         * int karsilastir(int,int) şeklinde bir tanımlamaya metodun imzası denir.
         */

        // metodun çağırılması
        Carp(3,5);


        Console.WriteLine(" Çarpma Metodu bitti");
        Console.WriteLine("---------------------------");

        // metod değer döndürüyorsa bunu yazdırmamız lazım

        int buyuk =Karsilastir(3,5);
        Console.WriteLine(buyuk);

        Console.WriteLine(" Karşılaştırma Metodu bitti");
        Console.WriteLine("---------------------------");

        // dinamik parametre tanımlaması
        double toplam = SeriToplam(5.25, 15.02, 25.75);
        Console.WriteLine("{0,5:0.##}",toplam);
        Console.WriteLine(" SeriToplam Metodu bitti");
        Console.WriteLine("---------------------------");


        // metodların aşırı yüklenmesi örnek
        double Satis1 = Satis(12.5,0.10);
        Console.WriteLine("{0,5:0.##}", Satis1);
        Console.WriteLine("çift parametre");

        double Satis2 = Satis(12.5);
        Console.WriteLine("{0,5:0.##}", Satis2);
        Console.WriteLine("tek parametre");
        
        Console.ReadKey();

    }

    // metod tanimlama
    // bu metodu çağırmak için static olarak tanımlamamız gerekmektedir.
    public static void Carp(int sayi1,int sayi2)
    {
        Console.WriteLine("KARSILASTIRMA METODU");
        Console.WriteLine($"ÇARPIM DEĞERİ {sayi1*sayi2}");
               
    }

    // geri değer döndürmesi için void i silip yerine döndüreceği değer tipini yazıyoruz
    public static int Karsilastir(int sayi1, int sayi2)
    {
        Console.WriteLine("KARSILASTIRMA METODU ÇALIŞTI");

        if (sayi1 > sayi2)
        {
            return sayi1;
        }
        else
        {
            return sayi2;
        }

        // return içerisinde de sayıları kontrol ettirebiliriz
        // return sayi1 > sayi2 ? sayi1 : sayi2;
       
    }

    // bir metodun içerisine birden çok hatta kaç tane olacağı belli olmayan parametre verilebilir
    // bunun için içerisine tanımlayabiliriz ancak parametre sayısı belirsiz olduğu durumlar için "params" sözcüğü kullanılabilir.
    private static double SeriToplam(params double[] seri)
    {
        double toplam = 0;
        foreach (double s in seri)
        {
            toplam += s;
            
        }
        return toplam;
    }

    // metodların aşırı yüklenmesi bir metodu iki farklı şekilde çağırabiliriz örn satış yapan bir metod olsun
    // bunun indirim ve kdv diye parametreleri olsun her ürün için indirim olmayacağı için bazen iki bazense tek bir parametre
    // kullanmamız gerekir buna metodların aşırı yüklenmesi denir.


    /// <summary>
    /// indirimli fiyat
    /// </summary>
    /// <param name="fiyat"></param>
    /// <param name="indirim"></param>
    /// <returns></returns>
    static double Satis(double fiyat,double indirim = 0)
    {
        double tutar = (fiyat * 1.18) - (fiyat * indirim); 
        return tutar;
    }
    /// <summary>
    /// indirimsiz fiyat
    /// </summary>
    /// <param name="fiyat"></param>
    /// <returns></returns>
    static double Satis(double fiyat)
    { 
        double tutar = fiyat * 1.18;
        return tutar;
    }


}