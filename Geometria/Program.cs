// See https://aka.ms/new-console-template for more information
namespace Geometria
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                int baseRettangolo = 0;
                int altezzaRettangolo = 0;
                string nomeRettangolo = "";
                Console.WriteLine("inserisci il nome del rettangolo: ");
                nomeRettangolo = Console.ReadLine();
                Console.WriteLine("inserisci la base del tuo rettangolo: ");
                baseRettangolo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\ninserisci l altezza del tuo rettangolo: ");
                altezzaRettangolo = Convert.ToInt32(Console.ReadLine());

                Rettangolo rettangolo1 = new Rettangolo(baseRettangolo, altezzaRettangolo, nomeRettangolo);

                rettangolo1.stampaRettangolo();

            }
        
        
        
        }




   
    
    
    
    
    }


}
