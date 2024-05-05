Console.WriteLine("Park Edilecek Araç Hangisi ? ");
Console.WriteLine("1 Otomobil");
Console.WriteLine("2 Minibüs");
Console.WriteLine("3 Kamyon");
Console.Write("Bir Secim Yapınız:");
int secim = Convert.ToInt32(Console.ReadLine());
switch (secim)
{
    case 1: Console.Write("Otomobil Kaç Saat Kalacak: ");
        double OtoPark = Convert.ToInt32(Console.ReadLine());
        double ucret = 10;
        
        if (OtoPark==1)
        {
            double sonuc=ucret*OtoPark;
            Console.WriteLine(sonuc);
        }
        else if (OtoPark>=2)
        {
            double oto=(ucret*OtoPark*25)/100;
            Console.WriteLine(oto);
        }
        break;
    case 2: Console.Write("Kaç Saat Kalacaksınız: ");
        double MiniPark = Convert.ToInt32(Console.ReadLine());
        double ucret2 = 15;
        
        if (MiniPark==1)
        {
            double sonuc1=ucret2*MiniPark;
            Console.WriteLine(sonuc1);
        }
        else if (MiniPark>=2)
        {
            double oto2=ucret2 * 0.25*MiniPark;
            Console.WriteLine(oto2);
        }
        
        break;
    case 3: Console.Write("Kaç Saat Kalacaksınız: ");
        double KamPark = Convert.ToInt32(Console.ReadLine());
        double ucret3 = 17;
        
        if (KamPark==1)
        {
            double sonuc2=ucret3*KamPark;
            Console.WriteLine(sonuc2);
        }
        else if (KamPark>=2)
        {
            double oto3=ucret3 * 0.25*KamPark;
            Console.WriteLine(oto3);
        }
        
        break;
    
}






