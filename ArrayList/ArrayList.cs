using System;
using System.Collections;

    internal class ArrayListOrnek
    {
        private static void Main(string[] args)
        {

            /*
             * ArrayList yapısını kullanabilmek için aşağıdaki şekilde tanımlanabilir.
             * var Listem = new System.Collections.ArrayList();
             * yada using System.Collections kütüphanesini import ederek ArrayList() ifadesini direkt kullanabiliriz
             */
            var listem = new ArrayList();

            //array object tutar  yani dizilerde yapamadığımız farklı türlerde değişkenleri tanımlayabiliriz.
            listem.Add(10);
            listem.Add("eğitim");
            listem.Add(true);
            listem.Add('e');

            // var listem = new ArrayList() { 10,"eğitim", true ,'e'}; // şeklinde de bir tanımlama yapabilirdik


            // dizi içinde dolaşma

            foreach (var e in listem)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------");

            // array içerisine istersek dizlerdeki elemanları atabiliriz bunu AddRange() ile yapıyoruz.
            int[] sayilar = new int[] { 1, 2, 3, 4 };
            listem.AddRange(sayilar);
            
            foreach (var e in listem)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();
            /* elemana erişme
             * üzerine eklediğimiz sayılar dizisinin içerisindeki herbir eleman yine yeni bir elemean dizi elemanı olarak 
             * listem içerisine eklendi bunu aşağıdaki şekilde içerisinden eklenen elemanların denk geldiği indis numarasıyla yazdırabiliriz.
             */

            Console.WriteLine(listem[5]);

            /* erişilen elemana başka bir değer atama
             * eriştiğimiz elemanı örn herhangi matematiksel işlemde kullanmak istersek obje olarak
             * elde ettiğimiz elemanı int  çevirmemiz gerek yada aldığımız elemanı var türünde örtülü değişken olarak tanımalyabiliriz
             * ama işlem kısmında yine int bir değere çevirmemiz gerekir özetle array içerisinden gelen değişken obje dir
             * bunu bizim convert etmemiz gereklidir.
             */

            // kutudan çıkarma " unboxing "
            var x = (int)listem[5];
            Console.WriteLine(x+100);

            // eleman silme
            // burada Remove için silinmesini isteğimiz değeri yazıyoruz örn ahmet mehmet 20 e gibi, indis yazmıyoruz
            listem.Remove(10);
            // eğer boolean bir değer silmek istersek
            listem.RemoveAt(1);
            
            Console.WriteLine();

            foreach (var e in listem)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();
            // eğer birden fazla eleman silmek istersek (başlangıç ve eleman sayısı) şeklinde parametre kullanırız.
            listem.RemoveRange(3, 3);

                  foreach (var e in listem)
                  {
                      Console.Write($"{e} ");
                  }


            Console.ReadKey();


        }
    }
