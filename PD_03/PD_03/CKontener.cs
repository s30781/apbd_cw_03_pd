namespace PD_03
{
    public class CKontener : Kontener
    {
        private string rodzajProduktu;
        private double temperatura;

        //slownik przedmiot,temp
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
            generateNumerSeryjny("C");
            //sprawdzamy czy w slowniku jest rodukt
            if (wymaganeTemperatury.ContainsKey(rodzajProduktu))
            {
                this.rodzajProduktu = rodzajProduktu; 
                //patrzymy czy temp nie ejst za niska
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

        //tostring dla kontenrea by wypisac info o nim
        public override string ToString()
        {
            return base.ToString() +
                   $"\n Rodzaj produktu: {rodzajProduktu}" +
                   $"\n Temperatura: {temperatura}°C";
        }
    }
}
