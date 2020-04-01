using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter birth date like this: dd.mm.yyyy:\n");
            var date = Console.ReadLine();
            DateTime birthDateTime = DateTime.Parse(date);
            var age = CalculateAge(birthDateTime);
            Console.Write($"Wow, you are {age.years} years or {age.days} days old.");
            Console.ReadKey();

        }
        static DateFormat CalculateAge(DateTime dob)
        {
            DateTime Now = DateTime.Now;
            int years = new DateTime(DateTime.Now.Subtract(dob).Ticks).Year - 1;
            DateTime PastYearDate = dob.AddYears(years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= Now)
                {
                    Months = i - 1;
                    break;
                }
            }

            int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
            int TotalDays = Days + (years * 365);
            return new DateFormat(TotalDays, years);
        }
    }
}
