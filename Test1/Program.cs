using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        public static string answer = string.Empty;
        static void Main(string[] args)
        {
            Menu();
            Console.WriteLine("Tryk på hvilken som helst knap for at afslutte");
            Console.ReadKey();
        }
        public static void Menu()
        {
            Console.WriteLine("Velkommen til bageri 'Rent Mel i posen'");
            string[] menus = { "Mad", "Drikke", "Afslut" };
            int tmp = 1;
            foreach(string item in menus)
            {
                Console.WriteLine($"{tmp}.{item}");
                tmp++;
            }
            answer = Console.ReadLine();
            while (answer != "3")
            {
                if (answer == "1")
                {
                    answer = Mad();
                }
                else if (answer == "2")
                {
                    answer = Drik();
                }
            }

        }
        public static string Mad()
        {
            Console.Clear();
            int tmp = 1;
            string[] food = { "Boller", "Brød", "Yoghurt", "Tilbage til forrige menu", "Afslut" };
            foreach (string item in food)
            {
                Console.WriteLine($"{tmp}.{item}");
                tmp++;
            }
            string choice = Console.ReadLine();
            if (choice == "4")
            {
                Menu();
            }else if (choice == "5")
            {
                answer = "3";
            }
            return answer;
        }
        public static string Drik()
        {
            Console.Clear();
            int tmp = 1;
            string[] food = { "Mælk", "Vand", "Kakao", "Tilbage til forrige menu", "Afslut" };
            foreach (string item in food)
            {
                Console.WriteLine($"{tmp}.{item}");
                tmp++;
            }
            string choice = Console.ReadLine();
            if (choice == "4")
            {
                Menu();
            }else if (choice == "5")
            {
                answer = "3";
            }
            return answer;
        }
    }
}