
namespace PD_03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Kontener k1 = new Kontener(10, 11, 12, 13, 14);
        k1.zaladuj(10);
        Console.WriteLine(k1);

        LKontener lk2 = new LKontener(10, 11, 12, 13, 14,true);
        Console.WriteLine(lk2);

        GKontener gk3 = new GKontener(20, 15, 2, 10, 100, 30,  true);
        Console.WriteLine("Przed rozladowaniem");
        gk3.zaladuj(70);
        Console.WriteLine(gk3);
        Console.WriteLine("Po rozladowaniu");
        gk3.rozladuj();
        Console.WriteLine(gk3);

        CKontener ck4 = new CKontener(20, 20, 20, 20, 20, "Bananas", 14);
        Console.WriteLine(ck4);
        
    }
}