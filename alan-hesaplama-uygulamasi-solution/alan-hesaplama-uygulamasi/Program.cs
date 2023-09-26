// See https://aka.ms/new-console-template for more information

int secim;

do
{

    Console.Clear();

    Console.WriteLine("Alan Hesaplama Uygulaması");
    Console.WriteLine("-------------------------");
    Console.WriteLine();

    Console.WriteLine("Menü");
    Console.WriteLine("----");
    Console.WriteLine("1) Kare Alanı Hesapla");
    Console.WriteLine("2) Dikdörtgen Alanı Hesapla");
    Console.WriteLine("3) Üçgen Alanı Hesapla");
    Console.WriteLine("4) Yamuk Alanı Hesapla");
    Console.WriteLine("0) Çıkış");
    Console.WriteLine();

    Console.Write("Seçiminiz : ");
    secim = int.Parse(Console.ReadLine());


} while (secim != 0);