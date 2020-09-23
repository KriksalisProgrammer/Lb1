using System;
using System.Collections.Generic;
using System.Text;

namespace Lb1
{
   public class Com : Profile
    {
        protected Profile a;
        private Profile b;
        public Com(Profile profile1, Profile profile2) 
        {
            a = profile1;
            b = profile2;
        }
        public void Comparable()
        {

            var arr1 = a._Appraisals;
            var arr2 = b._Appraisals;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Разница студента: {a.GetName().ToString()} и {b.GetName().ToString()}");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i=0;i<Subjects.Count;i++)
            {
               
                Console.WriteLine($"{Subjects[i]}{(int)(arr1[i]-arr2[i])}");

            }
        }
    }
}
