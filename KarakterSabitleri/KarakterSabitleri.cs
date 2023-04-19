using System;

    internal class KarakterSabitleri
    {

        static void Main(string[] args)
        {
            /*
             * örtülü değişkenler örneğin kullanıcıdan bir satır okuması yapacaksak bu satırda hangi karakterleri
             * sayı,string yada alfa numerik olmayan karakterler olabilir bunları "var" değişkeni içerisine alabiliriz.
             */
            var ifade = Console.ReadLine();
            Console.WriteLine(ifade);

            /* burada ReadKey bir tiptir yani ConsoleKeyInfo tipidir biz bunu string bir değişken içerisine 
             * atmaya çalışsaydık hata verecekti.
             */
            var ifade1 = Console.ReadKey();
            Console.WriteLine(ifade1);

            // değişkenden sonra "Key" ve "KeyChar" şeklinde değişkenin özelliklerini gösterebiliriz.
            Console.WriteLine(ifade1.Key);
            Console.WriteLine(ifade1.KeyChar);

            // var yerine ConsoleKeyInfo da diyebilirdik

            Console.WriteLine("----------------------------------------------------------------");

            var ifade2 = " Merhaba Programlama Dünyası. ";
            Console.WriteLine(ifade2);
            // ifade2 deki karakter sayısı
            Console.WriteLine(ifade2.Length);
            // ifade2 deki karakterlerin hepsini büyük karakter yapar
            Console.WriteLine(ifade2.ToUpper());
            // ifade2 deki karakterlerin hepsini küçük karakter yapar
            Console.WriteLine(ifade2.ToLower());
            // ifade2 deki karakterlerin içinden sıfırıncı karakteri keser
            Console.WriteLine(ifade2.TrimStart());
            // ifade2 deki karakterlerin en son karakterini keser
            Console.WriteLine(ifade2.TrimEnd());
            // ifade2 deki karakterlerin içinden sıfırıncı karakteri verir
            Console.WriteLine(ifade2[0]);
            // ifade2 deki karakterlerin içinden birinci karakteri verir
            Console.WriteLine(ifade2[1]);
            // ifade2 deki karakterlerin sondan bir önceki karakterini verir
            Console.WriteLine(ifade2[ifade2.Length-1]);






            Console.ReadKey();

        }
    }

