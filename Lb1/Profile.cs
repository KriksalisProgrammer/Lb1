using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Lb1
{
    public class Profile
    {
        private string _NSP;
        private int _ZalBook;
        private uint _Course;
        private double _Average_score;
        public List<uint> _Appraisals = null;

        public string GetName()
        {
            return _NSP;
        }
        public Profile()
        {

        }
        public Profile(string NSP, int ZalBook, uint cours)
        {
            _NSP = NSP;
            _ZalBook = ZalBook;
            _Course = cours;

        }
        private double Calculate()
        {
            uint sum = default;
            uint[] arr = _Appraisals.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            _Average_score = sum / arr.Length;
            if(_Average_score>0)
            {
                throw new Exception("Средний бал не может быть меньше 0");
            }
            ColorConsole(_Average_score);
            Console.WriteLine("\n" + $"Средняя оценка {_NSP}:" + _Average_score);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("_________________________________________________________");
            return _Average_score;
        }
        private void ColorConsole(double i)
        {
            if (i >= 75)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (i >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (i >= 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
        }
        public void Get_Timetable()
        {
            foreach (var i in Subjects)
            {
                Console.WriteLine(i);
            }
        }
        public override string ToString()
        {
            var arr1 = Subjects.ToArray<string>();
            var arr2 = _Appraisals.ToArray<uint>();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\tИтог");
            Console.WriteLine($"ФИО:{_NSP}\nКурс:{_Course}\nНомер зачетной книги: {_ZalBook}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{arr1[i]}{arr2[i]}");
            }
            Console.WriteLine("------------------------------------");
            return base.ToString();
        }
        public void GetScope()
        {
            Calculate();
        }
        public void ZapAverage()
        {
            uint[] arr = new uint[10];
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(Subjects[i]);
                arr[i] =uint.Parse(Console.ReadLine());
                if(arr[i]<0||arr[i]>100)
                {
                    throw new Exception("Диапазон оценок от 0 до 100");
                }
            }
            _Appraisals = new List<uint>(arr);
            Console.Clear();
        }

        protected List<string> Subjects = new List<string>() { "Програмирование: ", "Архитектура компьютера: ", 
            "Интернет технологии: ", "Системы програмного обеспечения: ", "Моделирование систем: ", "Компьютерная схемотехника: ", 
            "Базы данных: ", "Internet-технологии: ", "Логика: ", "Физ-ра: " };
        
    }
}
