namespace PD_03;

public class Kontener
{
    private int masa;
    private int wysokosc;
    private int wagaWlasna;
    private int glebokosc;
    private string numerSeryjny;
    private int maxLadownosc;
    private static int generator = 0;

    public Kontener(int masa, int wysokosc, int wagaWlasna, int glebokosc, int maxLadownosc)
    {
        this.masa = masa;
        this.wysokosc = wysokosc;
        this.wagaWlasna = wagaWlasna;
        this.glebokosc = glebokosc;
        this.numerSeryjny = generateNumerSeryjny();
        generateNumerSeryjny("K");
        this.maxLadownosc = maxLadownosc;
    }

    public string generateNumerSeryjny()
    {
        String wynik = "KON-typ-" + generator.ToString();
        generator++;
        return wynik;
    }

    public void generateNumerSeryjny(string typ)
    {
        this.numerSeryjny = "KON-" + typ + "-" + generator.ToString();
    }

    public string getNumerSeryjny()
    {
        return numerSeryjny;
    }

    public void checkPojemnosc()
    {
        if (masa > maxLadownosc)
        {
            throw new ContainerOverloadedException();
        }
    }

    public void zaladuj(int masa)
    {
        this.masa = masa;
        checkPojemnosc();
    }

    public void rozladuj()
    {
        this.masa = 0;
    }

    // Getter dla masy
    public int GetMasa()
    {
        return masa;
    }

    // Setter dla masy
    public void SetMasa(int nowaMasa)
    {
        if (nowaMasa >= 0)
        {
            masa = nowaMasa;
        }
    }

    public override string ToString()
    {
        return "Kontener: " + numerSeryjny +
               "\n masa " + masa +
               "\n wysokosc " + wysokosc +
               "\n waga wlasna " + wagaWlasna +
               "\n glebokosc " + glebokosc +
               "\n max pojemnosc " + maxLadownosc;
    }
}