
namespace PD_03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Kontener k1 = new Kontener(10, 11, 12, 13, 14);
        k1.zaladuj(10);
        Console.WriteLine(k1);
        
        Kontener k2 = new Kontener(15, 16, 17, 18, 19);
        k2.zaladuj(18);
        Console.WriteLine(k2);

        LKontener lk3 = new LKontener(10, 11, 12, 13, 14,true);
        Console.WriteLine(lk3);

        GKontener gk4 = new GKontener(20, 15, 2, 10, 100, 30,  true);
        Console.WriteLine(gk4);
        gk4.zaladuj(70);
        gk4.rozladuj();
        Console.WriteLine(gk4);
        
    }
}