
namespace PD_03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Kontener k1 = new Kontener(10, 11, 12, 13, 14);
        Kontener k2 = new Kontener(15, 16, 17, 18, 19);
        Console.WriteLine(k1.getNumerSeryjny());
        Console.WriteLine(k2.getNumerSeryjny());
        
        k1.zaladuj(10);
        Console.WriteLine(k1);
        
        k2.zaladuj(100);
        Console.WriteLine(k2);

    }
}