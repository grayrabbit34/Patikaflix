using System;
using System.Collections.Generic;
using Patikaflix;

class Program
{
    static void Main(string[] args)
    {
        List<TvShows> allTVShows = new List<TvShows>();

        while(true)
        {
            TvShows tvShow = new TvShows();

            Console.Write("Dizi adı giriniz: ");
            tvShow.Name = Console.ReadLine();

            while(true)
            {
                Console.Write("Dizi yapım yılını giriniz: ");
                int productionYear;
                bool isValid = int.TryParse(Console.ReadLine(), out productionYear);
                if (isValid)
                {
                    tvShow.ProductionYear = productionYear;
                    break;
                }                   
                else
                    Console.WriteLine("Geçersiz değer girdiniz.");
            }

            Console.Write("Dizinin türü: ");
            tvShow.Genre= Console.ReadLine();

            while (true)
            {
                Console.Write("Dizinin çıkış yılı: ");
                int airingYear;
                bool isValid = int.TryParse(Console.ReadLine(), out airingYear);
                if (isValid)
                {
                    tvShow.AiringYear = airingYear;
                    break;
                }
                else
                    Console.WriteLine("Geçersiz değer girdiniz.");
            }

            Console.Write("Dizinin yönetmeni: ");
            tvShow.Director = Console.ReadLine();

            Console.Write("Dizinin çıkış platformu: ");
            tvShow.Platform = Console.ReadLine();

            allTVShows.Add(tvShow);

            Console.Write("Yeni bir dizi eklemek ister misiniz? (e/h)");

            string answer = Console.ReadLine().ToLower();

            if (answer != "e")
                break;
        }

        List<ComedyShows> comedyShows = allTVShows
            .Where(show => show.Genre.Trim().ToLower() == "komedi")
            .Select(show => new ComedyShows
            {
                Name = show.Name,
                Genre = show.Genre,
                Director = show.Director,

            })
            .OrderBy(show => show.Name)
            .ThenBy(show => show.Director)
            .ToList();

        Console.WriteLine("\n--------------------\n");

        foreach(var item in comedyShows)
            Console.WriteLine($"Ad: {item.Name}, Tür: {item.Genre}, Yönetmen: {item.Director}");
    }
}





/*Bu pratikte sizlerden bir Diziler listesi oluşturmanız ve içerisindeki nesneleri tanımlamanız bekleniyor. Elemanların oluşturuluşu Console ekranı üzerinden olacak.

Yani kullanıcıya her diziyi oluşturup listeye ekledikten sonra yeni bir dizi ekleyip eklemediğini sormamız gerekiyor.

Ardından aşağıda istenilen işlemleri gerçekleştiriniz.
İlk listenizde bulunan komedi dizilerinden yeni bir liste oluşturunuz. Bu listede yalnızca Dizi Adı / Dizi Türü / Yönetmen bilgileri yer alsın (Yani başka bir class ihtiyacınız doğuyor.)
Bu yeni listenin bütün elemanlarını bütün özellikleriyle ekrana yazdırınız. Yazımın öncelikle dizi isimleri sonra da yönetmen isimleri baz alınarak sıralanmasına özen gösteriniz.
*/