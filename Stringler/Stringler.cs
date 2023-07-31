internal class Stringler
{
    private static void Main(string[] args)
    {

        Console.WriteLine("string fonksiyonları");
        Console.WriteLine("-----------------");
        Console.WriteLine("String.Format()");
        Kelime("Kelime1", "Kelime2");
        Console.WriteLine();

        //clone() Fonksiyonu değişkenin değerini referans alır ve değerini kopyalar adresini referans vermez buda cumle nin sonradan
        // değiştirildiğinde klon1cumle nin etkilenmemesini sağlar.
        Console.WriteLine("Clone()");
        string cumle = "örnek cümle";
        var klon1cumle = cumle.Clone();
        cumle = "örnek cümle yeni";
        Console.WriteLine(klon1cumle);
        Console.WriteLine();

        // EndsWith()-StartsWith() sonda ve başta karakteri arar ve bulursa true değilse false döner
        string karakter = "k";
        Console.WriteLine("sondaki karakter {0} {1} {2}",cumle,karakter,cumle.EndsWith(karakter) ? "ile bitiyor":"karakteri ile bitmiyor.");

        // IndexOf()-LastIndexOf() bulduğu ilk karakterin indexini döndürür ve sonraki karakterlere bakmaz.
        Console.WriteLine("cumle içindeki e karakterinin index numası: {0} ",cumle.IndexOf("e"));

        // Substring() Metnin içerisinden belli bir parçayı almaya yarar.
        Console.WriteLine(cumle.Substring(4,7));

        // Replace() bir karakteri başka bir karakter ile değiştirmek için kullanılır.
        Console.WriteLine(cumle.Replace(" ","-"));

        // Remove() bir karakteri atmak için kullanılır.
        Console.WriteLine(cumle.Remove(5));



        Console.ReadKey();

    }
    public static void Kelime(string kelime1, string kelime2)
    {
        // dönüş değişkeni oluşturulmak bazen gereksiz olabilir Bunun için String.Format() kullnılabilir.
        string kelimeler = String.Format("{0} {1}", kelime1, kelime2);
        Console.WriteLine(kelimeler);
    }
}