using System;

namespace Sconto
{
    class Program
    {
        static void Main(string[] args)
        {
            double sconto = 0;
            Console.WriteLine("Inserisci l'importo: ");
            double importo = double.Parse(Console.ReadLine());
            if (importo > 100)
            {
                sconto = (importo / 100) * 20;
                double importo_scontato = importo - sconto;
                Console.WriteLine("L'importo è di: " + importo_scontato);
            }
            else
                Console.WriteLine("L'importo è di: " + importo);
            Console.ReadLine();
        }
    }
}
