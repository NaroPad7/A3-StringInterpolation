// See https://aka.ms/new-console-template for more information
namespace GitExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.January 22, 2019(right aligned in a 40 character field)
            var date = DateTime.UtcNow;
            Console.WriteLine($"{date,40:MMMM dd, yyyy}");


            //2.2019.01.22
            Console.WriteLine($"{date:yyyy.MM. dd}");

            //3.Day 22 of January, 2019
            Console.WriteLine($"Day{date: d} of {date:MMMM,yyyy}");

            //4.Year: 2019, Month: 01, Day: 22
            Console.WriteLine($"Year:{date: yyyy,} Month:{date: MM,} Day:{date: dd}");

            //5.Tuesday(10 spaces total, right aligned)
            Console.WriteLine($"{date,10: dddd}");

            //6.     11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
            Console.WriteLine($"{date,10:t} {date,10:dddd}");

            //7.h:11, m:01, s:27
            Console.WriteLine($"h:{date:hh,} m:{date:m,} s:{date:s.}");

            //8.2019.01.22.11.01.27
            Console.WriteLine($"{date:yyyy.MM.dd.hh.mm.ss}");


            var pi = Math.PI;
            Console.WriteLine(pi);

            //1. Output as currency
            Console.WriteLine(pi.ToString("C2"));

            //Output as right-aligned (10 spaces), number with 3 decimal places
            Console.WriteLine($"{pi.ToString("N3")}");
        }
    }
}
