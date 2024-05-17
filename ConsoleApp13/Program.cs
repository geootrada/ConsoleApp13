using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            string stopWord = "exit";

            Console.Write(" Здравствуйте, это программа-напоминатель!\n " +
               "Введите сообщение, которое вам нужно сегодня напомнить: ");
            message = Console.ReadLine();

            while (message != stopWord)
            {
                Console.Write($" Напоминаем ваше сообщение - {message}\n " +
                $"Для завершения программы наберите {stopWord} или введите новое сообщение: ");
                message = Console.ReadLine();
            }
        }
    }
}
