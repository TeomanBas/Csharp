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


}