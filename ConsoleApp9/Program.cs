using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год для определения животного по восточному календарю:");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                int index = (year - 4) % 12;
                if (index < 0)
                    index += 12;
                string animal;
                switch (index)
                {
                    case 0:
                        animal = "Крыса";
                        break;
                    case 1:
                        animal = "Бык";
                        break;
                    case 2:
                        animal = "Тигр";
                        break;
                    case 3:
                        animal = "Кролик";
                        break;
                    case 4:
                        animal = "Дракон";
                        break;
                    case 5:
                        animal = "Змея";
                        break;
                    case 6:
                        animal = "Лошадь";
                        break;
                    case 7:
                        animal = "Коза";
                        break;
                    case 8:
                        animal = "Обезьяна";
                        break;
                    case 9:
                        animal = "Петух";
                        break;
                    case 10:
                        animal = "Собака";
                        break;
                    case 11:
                        animal = "Свинья";
                        break;
                    default:
                        animal = "Неизвестное животное";
                        break;
                }
                Console.WriteLine($"Год {year} символизирует животное: {animal}.");
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное число.");
            }
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
