internal class Program
{
    private static void Main(string[] args)
    {
        //Erisim_belirteci geri_donustipi metod_adi(parametreListesi/arguman)
        //{
            ////komutlar;
        //}

        int a = 2;
        int b = 3;

        int sonuc = Topla(a,b);
        Console.WriteLine(sonuc);

        Metodlar ornek = new Metodlar();
        ornek.EkranaYazdir(sonuc.ToString());

        int sonuc2 = ornek.ArttirveTopla(ref a,ref b);
        ornek.EkranaYazdir(sonuc2.ToString());
        ornek.EkranaYazdir((a+b).ToString());
    }

    static int Topla(int deger1,int deger2)
    {
        return deger1 + deger2;
    }

}

class Metodlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttirveTopla(ref int deger1,ref int deger2)
    {
        deger1+=1;
        deger2+=1;
        return deger1+deger2;
    }
}