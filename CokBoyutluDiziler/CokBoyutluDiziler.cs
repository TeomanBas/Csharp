using System;

    internal class CokBoyutluDiziler
    {
        private static void Main(string[] args)
        {
            // çok boyutlu dizler ,matrisler
            // virgül ifadesi dizinin 2 boyutlu olacağını ,eğer 2 tane varsa 3 boyutlu olacağını gösterir.
            double[,] matris = new double[,] {

            {1,2,3,4,5,6},
            {2,3,4,5,6,7},
            {3,4,5,6,7,8},
            {4,5,6,7,8,9}
        };
            // toplam değişkeni
            double gtoplam = 0;
            double stoplam = 0;

            // iki boyutlu matrisler ile uğraşırken 2 tane iç içe for döngüsü kullanmamız gerekli

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {

                    // diagonal elemaları yani hem i hemde j nin eşit olduğu durumları bulalım ve yıldız koyalım
                    if (i == j)
                        matris[i, j] = -1;

                    // çift olan elemanları bulduralım
                    if (matris[i, j] % 2 == 0)
                        matris[i, j] = 0;

                    Console.Write($"{matris[i, j],2}");
                    // toplamları tanımlıyoruz
                    stoplam += matris[i, j];

                }
                // satır toplamı yazdıralım
                Console.Write("   " + $"TOPLAM = {stoplam,2}");
                // diğer satıra temiz değişkenle girmesi için satır toplam değerini sıfırladık ama önce değeri genel toplam içine ekledik
                gtoplam += stoplam;
                stoplam = 0;


                Console.WriteLine();
            }
            // genel toplamı yazdıralım
            Console.WriteLine("   " + $"GENEL TOPLAM = {gtoplam,2}");
            Console.ReadKey();

        }
    }
