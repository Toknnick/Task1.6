using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfCrystal = 45;
            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine($"Стоймость кристала : {priceOfCrystal}");
            Console.WriteLine("Введите золото :");
            int gold = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько хотите купить кристалов?");
            int numberOfPurchasingCrystals = int.Parse(Console.ReadLine());

            gold -= priceOfCrystal * numberOfPurchasingCrystals ;
            Console.WriteLine($"Осталось золота : {gold}");
            Console.WriteLine($"куплено кристалов : {numberOfPurchasingCrystals}");

        }
    }
}
