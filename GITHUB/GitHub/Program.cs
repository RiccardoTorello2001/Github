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
            int numero = 0, value = 0;
            Console.WriteLine("inserisci un numero da convertire");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci la base per far convertire il numero");
            value = Convert.ToInt32(Console.ReadLine());
            string conversione = Convert.ToString(numero,value);
            //stampo il risultato
            Console.WriteLine($"il numero {numero} in base {value} divanta {conversione}");
            Console.ReadLine();
        }
    }
}
