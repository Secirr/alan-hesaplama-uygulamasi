// See https://aka.ms/new-console-template for more information

int secim;

do
{

    Console.Clear();

    EkranaBaslikYaz("Alan Hesaplama Uyguluması");
    EkranaBaslikYaz("Menü");
    Console.WriteLine("1) Kare Alanı Hesapla");
    Console.WriteLine("2) Dikdörtgen Alanı Hesapla");
    Console.WriteLine("3) Üçgen Alanı Hesapla");
    Console.WriteLine("4) Yamuk Alanı Hesapla");
    Console.WriteLine("0) Çıkış");
    Console.WriteLine();

    Console.Write("Seçiminiz : ");
    secim = int.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:
            // Kare Alan Hesaplama
            KareAlanHesaplama();
            break;

        case 2:
            // Dikdörtgen Alan Hesaplama

            break;

        case 3:
            // Üçgen Alan Hesaplama

            break;

        case 4:
            // Yamuk Alan Hesaplama

            break;

        default:
            break;
    }


} while (secim != 0);


static void EkranaBaslikYaz(string baslik)
{
    Console.WriteLine(baslik);

    for (int i = 0; i < baslik.Length; i++)
    {
        Console.Write("-");
    }

    Console.WriteLine();
    Console.WriteLine();
}

static void KareAlanHesaplama()
{
    Console.Clear();

    EkranaBaslikYaz("Kare Alan Hesaplama");
    Console.Write("Lütfen a kenar uzunluğu giriniz : ");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("Kare alanı : " + (a * a));


    Console.WriteLine("Lütfen devam etmek için bir tuşa basınız.");
    Console.ReadKey();
}