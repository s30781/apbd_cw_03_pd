namespace PD_03
{
    public class Kontenerowiec
    {
        private List<Kontener> listaKontenerow;
        private int maxPredkosc;
        private int maxLiczbaKontenerow;
        private int maxWagaWszystkichKontenerow;

        
        public Kontenerowiec(List<Kontener> listaKontenerow, int maxPredkosc, int maxLiczbaKontenerow, int maxWagaWszystkichKontenerow)
        {
            this.listaKontenerow = listaKontenerow ?? new List<Kontener>();
            this.maxPredkosc = maxPredkosc;
            this.maxLiczbaKontenerow = maxLiczbaKontenerow;
            this.maxWagaWszystkichKontenerow = maxWagaWszystkichKontenerow;
        }
        
        public Kontenerowiec(int maxPredkosc, int maxLiczbaKontenerow, int maxWagaWszystkichKontenerow)
        {
            this.listaKontenerow = new List<Kontener>(); 
            //inicjalizowanie pustej listy bo inaczej nie idze
            this.maxPredkosc = maxPredkosc;
            this.maxLiczbaKontenerow = maxLiczbaKontenerow;
            this.maxWagaWszystkichKontenerow = maxWagaWszystkichKontenerow;
        }
        
        public bool isTooHeavy()
        {
            int masaKontenerowLaczna = 0;
            foreach (var kontener in listaKontenerow)
            {
                masaKontenerowLaczna += kontener.GetMasa();
            }

            return masaKontenerowLaczna > maxWagaWszystkichKontenerow;
        }
        
        public void dodaj(Kontener kontener)
        {
            if (isTooHeavy() == false)
            {

                {

                }
                if (listaKontenerow.Count < maxLiczbaKontenerow)
                {
                    listaKontenerow.Add(kontener);
                }
                else
                {
                    Console.WriteLine("Maksymalna ilość kontenerów, nie można załadować nowego.");
                }
            }
            else
            {
                Console.WriteLine("Nie mozna juz wiecej zaladowac na statek");
            }
        }

        //wypisanie statek i info o kontenerach
        public override string ToString()
        {
            //jesli lista jest pusta to dajemy info
            string konteneryInfo;
            if (listaKontenerow.Count == 0)
            { konteneryInfo = "Brak załadowanych kontenerów"; }
            else
            { 
                konteneryInfo = "";
                foreach (var kontener in listaKontenerow)
                {
                    konteneryInfo += kontener.ToString() + "\n";
                }
            }
            
            //$ to miejsce na dane jak w cpp
            return $"Kontenerowiec\n" +
                   $"Max prędkość: {maxPredkosc} km/h" +
                   $"\nMax liczba kontenerów: {maxLiczbaKontenerow}" +
                   $"\nMax waga wszystkich kontenerów: {maxWagaWszystkichKontenerow} kg" +
                   $"\nZaładowane kontenery:" +
                   $"\n{konteneryInfo}";
        }
        public void usun(Kontener kontener)
        {
            if (listaKontenerow.Contains(kontener)) 
                //sprawdzamy czy ejst ten kotener wl liscie
            {
                //usuwamy kontener
                listaKontenerow.Remove(kontener);
                Console.WriteLine($"Kontener {kontener.getNumerSeryjny()} został usunięty ze statku.");
            }
            else
            {
                Console.WriteLine("Kontener nie znajduje się na statku.");
            }
        }
        
        public bool zastapKontener(string numerSeryjny, Kontener nowyKontener)
        {
            for (int i = 0; i < listaKontenerow.Count; i++)
            {
                if (listaKontenerow[i].getNumerSeryjny() == numerSeryjny)
                {
                    listaKontenerow[i] = nowyKontener;
                    Console.WriteLine($"Kontener {numerSeryjny} został zastąpiony nowym kontenerem.");
                    return true;
                }
            }
            Console.WriteLine($"Kontener o numerze seryjnym {numerSeryjny} nie został znaleziony.");
            return false;
        }
        
        public bool przeniesKontenerDoInnegoStatku(Kontenerowiec innyStatek, Kontener kontener)
        {
            if (listaKontenerow.Contains(kontener))
            {
                listaKontenerow.Remove(kontener);
                Console.WriteLine($"Kontener {kontener.getNumerSeryjny()} został usunięty ze statku.");
                innyStatek.dodaj(kontener);
                Console.WriteLine($"Kontener {kontener.getNumerSeryjny()} został przeniesiony na inny statek.");
                return true;
            }
            else
            {
                Console.WriteLine($"Kontener {kontener.getNumerSeryjny()} nie znajduje się na tym statku.");
                return false;
            }
        }

    }
}
