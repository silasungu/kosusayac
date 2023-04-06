

public class Program
{
 private static void Main(string[] args)
    {
        int adımBoyu = adımBoyuVer();
        int adımSayısı = adımSayısıVer();
        int kosulanSaat = saatVer();
        int kosulanDakika = dakikaVer();
        int toplamSure = (toplamSureVer(kosulanSaat, kosulanDakika));

        Console.WriteLine("{0} metre koştunuz.", toplamMesafe(adımBoyu, adımSayısı, toplamSure));

    }
}

#region adımBoyu
public static int adımBoyuVer()
{
    int _adımBoyu = 0;
    int minAdımBoyu = 10;
    int maxAdımBoyu = 150;
degerGir:
    Console.WriteLine("bir dakikada attığınız adım sayısını giriniz:");
    string _deger = Console.ReadLine();

    if (!Int32.TryParse(_deger, out _adımBoyu) || _adımBoyu > maxAdımBoyu || _adımBoyu < minAdımBoyu)
    {
        Console.WriteLine("girilen değer olası aralıklarda değildir.", maxAdımBoyu, minAdımBoyu);
        goto degerGir;
    }
    return _adımBoyu;

}
#endregion
#region adımSayısı
public static int adımSayısıVer()
{
    int _adımSayısı = 0;
    int enAzAdımSayısı = 0;
    int enCokAdımSayısı = 300;
degerGir:
    Console.WriteLine("Bir sakikada attığınız adım sayısını giriniz: ");
    string _deger = Console.ReadLine();


    if (!Int32.TryParse(_deger, out _adımSayısı)|| _adımSayısı > enCokAdımSayısı|| _adımSayısı< enAzAdımSayısı)
    {
        Console.WriteLine("girilen değer gerçekği yansıtmıyor.", enAzAdımSayısı, enCokAdımSayısı);
        goto degerGir;
    }
    return _adımSayısı;
}
#endregion
#region kosulanSaat
public static int saatVer()
{
    int _kosulanSaat = 0;
    int enUzunKosu = 24;
    int enKısaKosu = 0;
degerGir:
    Console.WriteLine("koşmak istediğiniz saati giriniz: ");
    string _deger = Console.ReadLine();


    if(!Int32.TryParse(_deger, out _kosulanSaat)|| _kosulanSaat< enKısaKosu || _kosulanSaat >enUzunKosu)
    {
        Console.WriteLine("girdiğiniz değer gerçekçi değil", enUzunKosu, enKısaKosu);
        goto degerGir;
    }
    return _kosulanSaat;
}
#endregion
#region kosulanDakika
public static int dakikaVer()
{
    int _kosulanDakika = 0;
    int enUzunKosu1 = 60;
    int enKısaKosu1 = 0;
degerGir:
    Console.WriteLine("koşmak istediğiniz dakikayı giriniz: ");
    string _deger = Console.ReadLine();


    if (!Int32.TryParse(_deger, out _kosulanDakika) || _kosulanDakika< enKısaKosu1 || _kosulanDakika > enUzunKosu1)
    {
        Console.WriteLine("girdiğiniz değer aralıkta değil", enUzunKosu1, enKısaKosu1);
        goto degerGir;
    }
    return _kosulanDakika;
}
#endregion
#region toplamSureVer
public static int toplamSureVer(int kosulanDakika,int kosulanSaat)
{
    int _toplamSure = kosulanDakika + (kosulanSaat * 60);
    return _toplamSure;
}
#endregion
#region Mesafe
public static double toplamMesafe(int adımSayısı, int adımBoyu, int toplamSure)
{
    double toplamMesafe = ((adımBoyu * adımSayısı) * toplamSure / 100);
    return toplamMesafe;
}
#endregion









