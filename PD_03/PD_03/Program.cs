
using System.Data.SqlTypes;

namespace PD_03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        //tworznie kontenera danego typu
        Kontener k1 = new Kontener(10, 11, 12, 13, 20);
        LKontener lk2 = new LKontener(15, 12, 113, 13, 40,true);
        GKontener gk3 = new GKontener(20, 13, 14, 10, 80, 30,  true);
        CKontener ck4 = new CKontener(25, 14, 15, 20, 100, "Bananas", 14);

        Kontener doZamiany1 = new Kontener(10, 11, 12, 13, 20);
        Kontener doZamiany2 = new Kontener(10, 11, 12, 13, 20);
        
        Console.WriteLine();
        //zaladowanie ladunku do kontenera
        k1.zaladuj(10);
        lk2.zaladuj(10);
        gk3.zaladuj(10);
        ck4.zaladuj(10);
        
        Console.WriteLine();
        //zaladowanie na statek
        Kontenerowiec statek = new Kontenerowiec(150, 5, 70);
        statek.dodaj(k1);
        statek.dodaj(lk2);
        statek.dodaj(gk3);
        statek.dodaj(ck4);
        Console.WriteLine(statek.ToString());
        
        Console.WriteLine();
        //usuniecie kontenera z statku
        statek.usun(k1);
        Console.WriteLine(statek.ToString());
        
        Console.WriteLine();
        //rozladownie kontenera
        lk2.rozladuj();
        Console.WriteLine(lk2.ToString());
        
        //zastapienie kontenera
        statek.zastapKontener(lk2.getNumerSeryjny(), doZamiany1);
        Console.WriteLine(statek.ToString());
        
        //zamiana miedzy statkami
        Kontenerowiec swithcer = new Kontenerowiec(10, 10, 10);
        swithcer.dodaj(doZamiany2);
        swithcer.przeniesKontenerDoInnegoStatku(statek, doZamiany2);
        Console.WriteLine(statek.ToString());
        Console.WriteLine(swithcer.ToString());
    }
}