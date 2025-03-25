namespace PD_03
{
    public class CKontener : Kontener
    {
        private string rodzajProduktu;
        private double temperatura; // Temperatura w °C

        // Słownik przechowujący wymagane temperatury dla różnych produktów
        private static readonly Dictionary<string, double> wymaganeTemperatury = new Dictionary<string, double>
        {
            { "Bananas", 13.3 },
            { "Chocolate", 18 },
            { "Fish", 2 },
            { "Meat", -15 },
            { "Ice cream", -18 },
            { "Frozen pizza", -30 },
            { "Cheese", 7.2 },
            { "Sausages", 5 },
            { "Butter", 20.5 }
        };

        public CKontener(int masa, int wysokosc, int wagaWlasna, int glebokosc, int maxLadownosc, string rodzajProduktu, double temperatura)
            : base(masa, wysokosc, wagaWlasna, glebokosc, maxLadownosc)
        {
            // Sprawdzamy, czy podany produkt jest w słowniku
            if (wymaganeTemperatury.ContainsKey(rodzajProduktu))
            {
                this.rodzajProduktu = rodzajProduktu;

                // Sprawdzamy, czy podana temperatura nie jest niższa niż wymagania dla tego produktu
                if (temperatura >= wymaganeTemperatury[rodzajProduktu])
                {
                    this.temperatura = temperatura;
                }
                else
                {
                    throw new Exception($"Temperatura kontenera jest za niska dla produktu {rodzajProduktu}. Minimalna temperatura to {wymaganeTemperatury[rodzajProduktu]}°C.");
                }
            }
            else
            {
                throw new Exception("Nieznany rodzaj produktu.");
            }
        }

        public string GetRodzajProduktu()
        {
            return rodzajProduktu;
        }

        public double GetTemperatura()
        {
            return temperatura;
        }

        // Nadpisujemy metodę ToString, aby dodać informacje o produkcie i temperaturze
        public override string ToString()
        {
            return base.ToString() +
                   $"\n Rodzaj produktu: {rodzajProduktu}" +
                   $"\n Temperatura: {temperatura}°C";
        }
    }
}
