
namespace PD_03;

public class LKontener : Kontener, IHazardNotifier
{
    private bool niebezpieczne;

    public LKontener(int masa, int wysokosc, int wagaWlasna, int glebokosc, int maxLadownosc, bool niebezpieczne) : base(masa, wysokosc, wagaWlasna, glebokosc, maxLadownosc)
    {
        this.niebezpieczne = niebezpieczne;
        generateNumerSeryjny("L");
        powiadomienie();
    }
    

    public void powiadomienie()
    {
        if (niebezpieczne == true)
        {
            Console.WriteLine("UWAGA KONTENER:" + getNumerSeryjny() + " ZAWIERA MATERIAŁY NIEBEZPIECZNE" );
        }
    }
}