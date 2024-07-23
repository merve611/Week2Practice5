using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Threading.Channels;

public class Program
{
    static void Main()
    {
        Lyrics();
        Ramdomm();
        Multiplication(5, 9);
        Greet("merve" , "akkoyunlu");

    }

    //Geriye Değer Döndürmeyen Bir void metot.
    static void Lyrics()
    {
        Console.WriteLine("Ne bir eksik ne bir fazla canımsın sen.");
    }

    //Geriye Tamsayı Döndüren Bir metot
    public static int Ramdomm()
    {
        Random random = new Random();
        int sayi = random.Next(2, 20);


        int kalan = sayi % 2;

        Console.WriteLine("Rastgele sayının 2 ile bölümünden kalan :  " + kalan);
        return kalan;
    }

    //Parametre Alan ve Geriye Değer Döndüren Bir Metot

    public static int Multiplication(int a, int b)
    {
        int carpim = a * b;
        Console.WriteLine(carpim);

        return carpim;
    }

    //Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

    static void Greet (string firstName, string lastName)
    {
        Console.WriteLine("Hoşgeldiniz ! " + firstName + lastName);
    }


        

}