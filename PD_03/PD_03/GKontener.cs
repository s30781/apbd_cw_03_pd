namespace PD_03;

public class GKontener : Kontener, IHazardNotifier
{
    private int atmosfery;
    private bool niebezpieczny;

    public GKontener(int masa, int wysokosc, int wagaWlasna, int glebokosc, int maxLadownosc, int atmosfery, bool niebezpieczny) : base(masa, wysokosc, wagaWlasna, glebokosc, maxLadownosc)
    {
        this.atmosfery = atmosfery;
        this.niebezpieczny = niebezpieczny;
        generateNumerSeryjny("G");

    }

    public void rozladuj()
    {
        //zostaje 5% masy w kontenerze typu G
        SetMasa((int)(GetMasa() * 0.05));
    }

    public void powiadomienie()
    {
        Console.Write("Kontener jest niebezpieczny");
    }
}