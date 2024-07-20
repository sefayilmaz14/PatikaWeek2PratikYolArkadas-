
 // Değişken Tanımlarını Gerçekleştirdim
string bolge;
int kisisayisi = 0;
int bolgeucreti = 0;
string ulasimturu;
int ulasimucreti = 0;
string tekrarplan;
int toplamtutar = 0;    
bool cikis = false;
bool cikis2 = false;
int totalbolgeucreti = 0;
do
{
    Console.WriteLine("Merhabalar Tatilcim'e Hoşgeldeniz\n Sevdiklerinizle Huzurlu Tatilin Keyfi Tatilcim İle Sizinle");
    Console.WriteLine("Şuan Uygun Olan Tatil Programlarından Hangisini Seçmek İstersiniz");
    Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)\r\n\r\n2 - Marmaris (Paket başlangıç fiyatı 3000 TL)\r\n\r\n3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
    bolge = Console.ReadLine().ToLower(); // Paket Girişi

  if (bolge != "bodrum" && bolge != "marmaris" && bolge != "çeşme")// Belirtilen yazıdan farklı bir yazı girilse paketler ekrana tekrardan yazılacak
    { 
    Console.WriteLine("Lütfen Hizmet Verdiğimiz Bölgeler Üzerinden Seçim Yapınız.");
    continue;
    }
    Console.WriteLine("Program Katılacak Kişi Sayısı Giriniz.");
    kisisayisi =Convert.ToInt32(Console.ReadLine()); // Kişi Sayısı Girişi


    // Paket seçimi ve fiyatlandırma için switch yapısı
    switch (bolge)

    {
        case "bodrum": 
            Console.WriteLine("Bodrum Paketi Seçimi Yapıldı ");
            Console.WriteLine("Bodrum Bölgesinde ; Orak Adası , Bardakçı Koyu , Bodrum Kalesi Gibi Turistik Yerleri Gezebilirsiniz. ");
            bolgeucreti = 4000;
            break;

        case "marmaris":
            Console.WriteLine("Marmaris Paketi Seçimi Yapıldı");
            Console.WriteLine("Marmaris Bölgesinde Amos Koyu , Kumlubük Koyu , Arkeoloji Müzesi Gibi Turistik Yerleri Gezebilirsiniz .");
            bolgeucreti = 3000;
            break;

        case "çeşme":
            Console.WriteLine("Çeşme Paketi Seçimi Yaptınız");
            Console.WriteLine("Çeşme Bölgesinde Alataçı'yı, Değirmenleri , Ünlü Beachleri Gezebilirsiniz");
            bolgeucreti = 5000;
            break;
    }
    totalbolgeucreti = bolgeucreti * kisisayisi;
   
    // Ulaşım seçeneği ve fiyatlandırma için döngü
    do
    {
        Console.WriteLine("Tatil Bölgesine Ulaşım Seçeneğini Seçiniz ");
        Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\r\n\r\n2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL) \n Seçenekleri Sayı Olarak Yapınız  ");
        ulasimturu = (Console.ReadLine());

        if (ulasimturu != "1" && ulasimturu != "2") // İstenilen giriş yapılmaz ise ulaşım seçim ekranı tekrar yazılacak
        {
            Console.WriteLine("Lütfen Sadece Ekranda Görüntülenen Seçenekler İle Seçim Yapınız");
            continue;

        }

        // Ulaşım ücreti ve seçimi için switch yapısı
            switch (ulasimturu)
        {
            case "1":
                ulasimucreti = kisisayisi * 1500;
                ; break;
            case "2":
                ulasimucreti = kisisayisi * 4000;
                ; break;
        }
        toplamtutar = totalbolgeucreti + ulasimucreti; // Total ücretlendirme kısmı

        Console.WriteLine($"Planlamış olduğunz {kisisayisi} kişilik {bolge} Bölgemize Tatil Organizasyonu Ulaşım Fiyatı Dahil {toplamtutar}'dır");
        Console.WriteLine("Başka Bir Planlama Yapmak İstermisiniz");
        tekrarplan = Console.ReadLine().ToLower();// Tekrar plan yapılması için veri girişi

        if (tekrarplan == "Hayır")
        {
            Console.WriteLine("Teşekkür Eder İyi Günler Dileriz.");
            cikis2 = true;
            cikis = true;
        }
        else if (tekrarplan == "evet")
        {
            cikis2 = true;
        }
    }
    while (!cikis2);
    }
while(!cikis);
