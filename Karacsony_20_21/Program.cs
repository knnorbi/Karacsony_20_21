using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karacsony_20_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hanyadik nap van az évben?");
            string beolvasottSzoveg = Console.ReadLine();
            int maiNap = int.Parse(beolvasottSzoveg);
            int karacsony = 358;
            int napokKaracsonyig = karacsony - maiNap;
            Console.WriteLine("Ennyi nap van karácsonyig: " + napokKaracsonyig);

            Console.WriteLine("Hány embert szeretnél megajándékozni?");
            int ember = int.Parse(Console.ReadLine());
            Console.WriteLine("Egy embernek hány ajándékot szeretnél adni?");
            int ajandekPerEmber = int.Parse(Console.ReadLine());
            Console.WriteLine("Hány ajándékot fogsz elkészíteni saját magad?");
            int diy = int.Parse(Console.ReadLine());
            int ajandekokSzama = ember * ajandekPerEmber - diy;
            Console.WriteLine("Összesen ennyi ajándékot kell venned: " + ajandekokSzama);
            double diyPerEmber = (double)diy / ember;
            Console.WriteLine("Egy ember átlagosan ennyi saját készítésű ajándékot fog kapni: " + diyPerEmber);

            // if (ajandekokSzama == 0)
            // if (diy == ember * ajandekPerEmber)
            if (diyPerEmber == ajandekPerEmber)
            {
                Console.WriteLine("Szép munka!");
            }
            else if (diyPerEmber > (double)ajandekPerEmber / 2)
            {
                Console.WriteLine("Ez nagyon rendes tőled!");
            }
            else
            {
                Console.WriteLine("Szerintem ennél többet kellene!");
            }

            Console.ReadKey();
        }
    }
}
