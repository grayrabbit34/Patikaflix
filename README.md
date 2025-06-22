# 🎬 Patikaflix - TV Show Listesi Uygulaması

Bu proje, kullanıcıdan alınan dizi bilgilerini listeleyen, türü "Komedi" olanları filtreleyen ve yalnızca belirli bilgileri içeren yeni bir liste oluşturan basit bir C# console uygulamasıdır.

## 📌 Amaç

C# dilinde aşağıdaki konuları pekiştirmek:
- Class ve nesne kullanımı
- Liste (List<T>) oluşturma ve nesne ekleme
- `Console.ReadLine()` ile kullanıcıdan veri alma
- `TryParse` ile hata kontrolü
- LINQ ile filtreleme, dönüştürme ve sıralama
- `foreach` ile listeyi ekrana yazdırma

## 🧱 Kullanılan Sınıflar

### `TvShows`  
Uygulamanın temel sınıfıdır ve bir dizinin tüm bilgilerini içerir:
- Name (string)
- ProductionYear (int)
- Genre (string)
- AiringYear (int)
- Director (string)
- Platform (string)

### `ComedyShows`  
Yalnızca komedi dizilerine ait basitleştirilmiş bir modeldir:
- Name (string)
- Genre (string)
- Director (string)

## 🚀 Uygulama Akışı

1. Kullanıcıdan dizi bilgileri alınır.
2. Bilgiler `TvShows` sınıfından oluşturulan nesnelere aktarılır ve listeye eklenir.
3. Kullanıcı yeni bir dizi girip girmeyeceğini belirtir.
4. Tüm diziler toplandıktan sonra, türü "Komedi" olanlar LINQ ile filtrelenir.
5. Bu komedi dizileri yeni bir `ComedyShows` listesine aktarılır ve sıralanır.
6. Sonuçlar ekrana yazdırılır.
