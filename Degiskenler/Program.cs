// See https://aka.ms/new-console-template for more information
using System;

namespace Degiskenler
{
    class Program
    {
        static void Main()
        {
            User kullanici = new User("Berk Ali SARI", 19, "berkalisari679@gmail.com");
            Console.WriteLine(kullanici);

            Console.ReadLine();
        }
    }
}
/*Public: Her yerden erişilebilir.

Örnek: Bir park herkes tarafından kullanılabilir

Private: Sadece tanımlandığı sınıf içinde erişilebilir.

Örnek:  Bir evin anahtarı sadece ev sahibinde bulunur.

Protected: Sadece tanımlandığı sınıf ve ondan türetilen sınıflar tarafından erişilebilir.

Örnek: Bir şirketin çalışan kimlik bilgileri, sadece çalışanlar ve yöneticiler tarafından görülebilir.

Internal: Aynı proje (assembly) içinde erişilebilir, dışardan erişilemez.

Örnek: Bir kütüphanedeki kitap takip sistemi sadece kütüphane çalışanları tarafından kullanılabilir, dışardan erişilemez.*/
