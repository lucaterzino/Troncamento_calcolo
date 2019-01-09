using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errore_troncamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //inizializiamo le variabile con double

            double tronc = 0.000000095;
            double spazio = 0;
            double ms = 1676;
            double errore_tempo = 0;

            //calcolo dell' tempo errato
            Console.WriteLine("Calcolo del tempo errato:");
            Console.WriteLine(" ");
            errore_tempo = tronc * 100 * 60 * 60 * 10;
            Console.WriteLine($"Il tempo errato è di {errore_tempo}");
            Console.WriteLine(" ");

            //calcolo dello spazio
            Console.WriteLine("Calcolo dello spazio:");
            Console.WriteLine(" ");
            spazio = ms * errore_tempo;
            Console.WriteLine($"la misura dello spazio è di {spazio}");

            Console.ReadLine();
        }
    }
}
