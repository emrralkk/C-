class ogrenci
{
    public string adi { get; set; }
    public string soyadi { get; set; }
    public string sinifi { get; set; }
    
    public ogrenci(string ad, string soyad, string sinif)
    {
        adi = ad;
        soyadi = soyad;
        sinifi = sinif;
    }
}

new ogrenci()=