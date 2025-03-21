namespace PD_03
{
    [Serializable]
    public class ContainerOverloadedException : Exception
    {
        //default komunikat o bledzie
        public ContainerOverloadedException()
            : base("Do kontenera zapakowana za dużo. Towar za ciężki.")
        {
            Console.WriteLine();
            Console.WriteLine("KONTENER ZA CIEZKI");
            Console.WriteLine();
        }

        //komunikat jak damy stringa
        public ContainerOverloadedException(string message)
            : base(message)
        {
            
        }

        //Komunikat i wewnętrzny wyjątek
        //nie ukrywam ze nw co to robi ale na stronie MS jest tak wiec kopiowalem
        public ContainerOverloadedException(string message, Exception inner)
            : base(message, inner)
        {
        }
        
    }
}