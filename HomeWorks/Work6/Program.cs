using System;

namespace Work6
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldInWalet;
 //           int cristalForSales;
            int cristalNead;
            int crystaPrice = 1;

            Console.Write("Введите колличество золота : ");
            goldInWalet = Convert.ToInt32( Console.ReadLine());
            
            Console.WriteLine("Вы можете купить " + (goldInWalet / crystaPrice) + " кристалов");
            Console.WriteLine("Введите количество кристалов которые хотите купить : ");
            cristalNead = Convert.ToInt32(Console.ReadLine());
            goldInWalet = goldInWalet - cristalNead * crystaPrice;
            Console.WriteLine($"у вас осталось {goldInWalet} золота и крисалов {cristalNead}");
        }
    }
}
