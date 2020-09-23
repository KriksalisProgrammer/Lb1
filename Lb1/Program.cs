using System;
using System.Collections.Generic;

namespace Lb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.Write("Введите ФИО Студента: ");
            string NSP = Console.ReadLine();
            if (program.IsNumberContains(NSP)||NSP==""||NSP==" ")
            {
                throw new Exception("Некоректный ввод!");
            }
            Console.Write("Введите номер зачетной книги: ");
            int ZalBook = int.Parse(Console.ReadLine());
            Console.Write("Введите номер курса: ");
            uint Cours = uint.Parse(Console.ReadLine());
            Profile profile = new Profile(NSP,ZalBook,Cours);
            profile.ZapAverage();
            profile.ToString();
            profile.GetScope();
            Console.Write("Введите ФИО Студента: ");
            string NSP1 = Console.ReadLine();
            if (program.IsNumberContains(NSP1) || NSP1 == "" || NSP1 == " ")
            {
                throw new Exception("Некоректный ввод!");
            }
            Console.Write("Введите номер зачетной книги: ");
            int ZalBook1 = int.Parse(Console.ReadLine());
            Console.Write("Введите номер курса: ");
            uint Cours1 = uint.Parse(Console.ReadLine());
            Profile profile1 = new Profile(NSP1, ZalBook1, Cours1);
            profile1.ZapAverage();

            profile.ToString();
            profile.GetScope();
            profile1.ToString();
            profile1.GetScope();
            Com com1 = new Com(profile,profile1);
            com1.Comparable();

        }
       
        bool IsNumberContains(string input)
        {
            foreach (char c in input)
                if (Char.IsNumber(c))
                    return true;
            return false;
        }
    }
}
