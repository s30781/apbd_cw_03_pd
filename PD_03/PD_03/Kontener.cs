namespace PD_03;

public class Kontener
{
    private int masa; //w kg
    private int wysokosc; //w cm
    private int wagaWlasna; //w kg (waga samego kontenera)
    private int glebokosc; //w cm
    private String numerSeryjny; //ma zazcynac sie od KON-rodzaj_kontenera-liczba
    private int maxLadownosc; //w kg
    private static int generator = 0;


    public Kontener(int masa, int wysokosc, int wagaWlasna, int glebokosc, int maxLadownosc)
    {
        this.masa = masa;
        this.wysokosc = wysokosc;
        this.wagaWlasna = wagaWlasna;
        this.glebokosc = glebokosc;
        this.numerSeryjny = generateNumerSeryjny();
        this.maxLadownosc = maxLadownosc;
    }

    public string generateNumerSeryjny()
    {
        String wynik = "KON-typ-" + generator.ToString();
        generator++;
        return wynik;
    }

    public String getNumerSeryjny()
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
    
    public override string ToString()
    {
        return "Kontener: " + numerSeryjny +
               "\n wysokosc " + wysokosc +
               "\n waga wlasna " + wagaWlasna +
               "\n glebokosc " + glebokosc +
               "\n max pojemnosc " + maxLadownosc;
        
    }
}