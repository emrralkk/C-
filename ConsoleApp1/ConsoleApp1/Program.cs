Console.WriteLine("hello, world!");
 Console.Write("isim giriniz:");
 string isim = Console.ReadLine();

string yıl;
 Console.Write("ayse dogum tarıhı:" );
yıl=Console.ReadLine();


 string add, soyad, sehir;
 Console.Write( "adınızı giriniz:" );
 add = Console.ReadLine();
 Console.Write("soyadınızı giriniz:");
 soyad= Console.ReadLine();
 Console.Write("şehir ismi giriniz:");
 sehir= Console.ReadLine();
 Console.WriteLine("adınız   : "+add );
 Console.WriteLine("soyadınız: " + soyad );
 Console.WriteLine("sehirinz : " + sehir);
 string sehiri, plaka;

 Console.WriteLine(  "sehir adını girin");
 sehiri = Console.ReadLine();
 Console.WriteLine("plaka kodunu girin");
 plaka= Console.ReadLine();
 Console.WriteLine("sehir:{0} plaka : {1}",sehir,plaka);
 string adı,soyadd, meslek;

 Console.WriteLine("adınızı giriniz");
 adı = Console.ReadLine();

 Console.WriteLine("soyisimizi giriniz");
 soyadd= Console.ReadLine();

 Console.WriteLine("meslek bilgisi");
 meslek = Console.ReadLine();

 Console.WriteLine("ad:{0} soad:{1} meslek:{2}", adı, soyad, meslek);
 Console.WriteLine($"isim :{adı} soyad:{soyad}meslek:{meslek}");
 int sayi1, sayi2, toplam;
 sayi1 = 10;
 sayi2 = 20;
 toplam = sayi1 + sayi2;
 Console.WriteLine("toplam = " + toplam);
 int sınav, test, sözlü, ortalamaa;
 Console.Write("sınav sonuç:");
 sınav = Convert.ToInt32(Console.ReadLine());

 Console.Write("test sonuç:");
 test = Convert.ToInt32(Console.ReadLine());

 Console.Write("sözlü sonuç:");
 sözlü = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("ortalamanız   :  " +(sınav + test + sözlü) / 3);


 int sayi1i = 10;
 int sayi2i = 5;
 int carpım;
 carpım = sayi1i * sayi2i;
 Console.WriteLine ("sonuc : " + (carpım));
 string ad, soyadı, numara;
 int not1, not2, not3, ortalama;
 Console.Write("öğrenci adı: ");
 ad = Console.ReadLine();
 Console.Write("öğrenci soyadı: ");
 soyadı=Console.ReadLine();
 Console.Write("öğrenci numarası: ");
 numara =Console.ReadLine();
 Console.WriteLine();
 Console.WriteLine("**bilgi**");
 Console.WriteLine();
 Console.Write($"adı:{ad} soyad:{soyadı} numarası:{numara}");
 Console.WriteLine();
 Console.WriteLine();
 Console.Write("1.notu giriniz :");
 not1=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine();
 Console.Write("2.notu giriniz :");
 not2=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine();
 Console.Write("3.notu giriniz :");
 not3 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine();
 Console.WriteLine("ortalamanız   :  " + (not1 + not2 + not3) / 3);

 //odevvvvvv
 //int sayi1 = 10;
 //int sayi2 = 3;
 //int sayi3 = 2;
 //int sayi4 = 4;
 //int carpım;
 //int toplam;
 //int cıkartma;
 //int bolme;
 //carpım=sayi1 * sayi2;
 //toplam=sayi3 + sayi4;
 //cıkartma=sayi1 - sayi2;
 //bolme=sayi1 / sayi3;



 int uzunkenar, kisakenar;
 int cevre1, alan;
 Console.WriteLine("uzunkenarı girin");
 uzunkenar = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("kısa kenar girin");
 kisakenar = Convert.ToInt32(Console.ReadLine());
 cevre1 = (kisakenar + uzunkenar) * 2;
 alan = kisakenar * uzunkenar;
 Console.WriteLine("dikdortgenin alanaı: {0} cevresi: {1}" , alan, cevre1);
 //!!!!!!   { } bunlar satırda varsa virgül konulur     !!!!!


 int kenar1, kenar2,kenar3,cevre;
 Console.WriteLine("kenar1 girin");
 kenar1=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("kenar2 girin");
 kenar2=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("kenar3 girin");
 kenar3 = Convert.ToInt32(Console.ReadLine());
 cevre=kenar1+kenar2+kenar3;
 Console.WriteLine("cevre toplamı:" +cevre);
 int sayi11 = 15;
 int sayi22 = 3;
 int sonuc=(sayi1+sayi2);
 Console.WriteLine(sonuc);
 int sonuc2=(sayi1-sayi2);
 Console.WriteLine(sonuc2);
 int sonuc3=(sayi1*sayi2);
 Console.WriteLine(sonuc3);
 int sonuc4=(sayi1/sayi2);
 Console.WriteLine(sonuc4);
 int sonuc5 = ((sayi1 + sayi2) * (sayi1 + sayi2));
 Console.WriteLine(sonuc5);

 



 Console.ReadLine();