using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sayıları girin (virgülle ayırarak):");
        string input = Console.ReadLine();

        int[] sayilar = input.Split(',')
                             .Select(int.Parse)
                             .ToArray();

        double sonuc = OrtalamaHesapla(sayilar);
        Console.WriteLine($"Ortalama Sonucu: {sonuc}");
    }

    static double OrtalamaHesapla(params int[] sayilar)
    {
        int toplam = 0;
        foreach (int s in sayilar)
        {
            toplam += s;
        }
        return toplam / (double)sayilar.Length;
    }
}
