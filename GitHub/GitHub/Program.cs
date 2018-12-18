using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            //inizializzo una variabile ad intero
            int numero = 0;
            Console.WriteLine("inserisci un numero da convertire");
            numero = Convert.ToInt32(Console.ReadLine());
            string conversione = Convert.ToString(numero,2);
            //stampo il risultato
            Console.WriteLine($"il numero {numero} in base binaria divanta {conversione}");
            Console.ReadLine();
        }
    }
}
