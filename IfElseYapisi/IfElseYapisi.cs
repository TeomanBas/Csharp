using System;
 class IfElseYapisi
{
    private static void Main(string[] args)
    {
        // tek mi çift mi?
        // TekMiCiftMi();

        // mutlak değer
        // MutlakDeger();


        // (char) konsoldan okunan ifadeyi char türüne dönüştürüyoruz bu işleme cast işlemi deniliyor
        var k = (char)Console.Read();
        if (char.IsDigit(k))
        {
            Console.WriteLine("girilen ifade rakamdır");
        }else if (char.IsLower(k))
        {
            Console.WriteLine("gelen ifade küçük harfdir");
        }else if (char.IsUpper(k))
        {
            Console.WriteLine("gelen ifade büyük harfdir");
        }
        else
        {
            Console.WriteLine("gelen ifade bilinmeyen karakterdir.");
        }

        Console.ReadKey();

    }

    private static void MutlakDeger()
    {
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        if (sayi1 < 0)
        {
            Console.WriteLine($" |{sayi1}| = {sayi1 * -1}");
        }
        else
        {
            Console.WriteLine($" |{sayi1}| = {sayi1}");
        }
    }

    private static void TekMiCiftMi()
    {
        Console.WriteLine(" Bir sayi giriniz: ");
        /* burada ReadKey string bir değer döndürür bunu int e çevirmemiz gereklidir bunun için Convet.ToInt32() içerisine
         * tanımlayarak gelen ifadeyi int e çevirmiş oluruz
         */
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi % 2 == 0)
        {
            Console.WriteLine($"{sayi} çift bir sayıdır");
        }
        else
        {
            Console.WriteLine($"{sayi} tek bir sayıdır");
        }
    }
}