using System;

namespace Level_one
{
    internal class Program
    {
        enum enWeekDays
        {
            Monday,     // 0
            Tuesday,    // 1
            Wednesday,  // 2
            Thursday,   // 3
            Friday,     // 4
            Saturday,   // 5
            Sunday      // 6
        }

        //if you set a value , it will auto number everything after it.
        enum enCategories
        {
            Electronics,    // 0
            Food,           // 1
            Automotive = 6, // 6
            Arts,           // 7
            BeautyCare,     // 8
            Fashion         // 9
        }

        enum status
        {
           maryed,
           unmaryed,
        }


        //Enum can have any numarical data type byte, sbyte, short, ushort, int, uint, long, or ulong
        //but not string

        enum enCategories2 : byte
        {
            Electronics = 1,
            Food = 5,
            Automotive = 6,
            Arts = 10,
            BeautyCare = 11,
            Fashion = 15
        }
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            enWeekDays WeekDays;

            WeekDays = enWeekDays.Friday;
            Console.WriteLine(WeekDays);
            // Annonymous type
            var student = new { Id = 20, FirstName = "Mohammed", LastName = "Abu-Hadhoud" };

            Console.WriteLine("\nExample1:\n");
            Console.WriteLine(student.Id); //output: 20
            Console.WriteLine(student.FirstName); //output: Mohammed
            Console.WriteLine(student.LastName); //output: Abu-Hadhoud

            //You can print like this:
           Console.WriteLine(student);



            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);

            //number of 100-nanosecond intervals that have elapsed
            //since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. 

            DateTime dt = new DateTime();
            Console.WriteLine(DateTime.MinValue.Ticks);  //min value of ticks
            Console.WriteLine(DateTime.MaxValue.Ticks); // max value of ticks


            DateTime dt5 = new DateTime(2023, 2, 21);

            // Hours, Minutes, Seconds
            TimeSpan ts_test = new TimeSpan(49, 25, 34);
            Console.WriteLine(ts_test);
            Console.WriteLine(ts_test.Days);
            Console.WriteLine(ts_test.Hours);
            Console.WriteLine(ts_test.Minutes);
            Console.WriteLine(ts_test.Seconds);

            //this will add time span to the date.
            DateTime newDate = dt5.Add(ts_test);

            //Convert string to datatime

            
            Console.WriteLine("****************************************************");
            
            var str = "6/12/2023";
            DateTime dt_con;

            var isValidDate = DateTime.TryParse(str, out dt_con);

            if (isValidDate)
                Console.WriteLine(dt_con);
            else
                Console.WriteLine($"{str} is not a valid date string");

           
            //invalid string date
            var str2 = "6/65/2023";
            DateTime dt2_con;

            var isValidDate2 = DateTime.TryParse(str2, out dt2_con);

            if (isValidDate2)
                Console.WriteLine(dt2);
            else
                Console.WriteLine($"{str2} is not a valid date string");

            //****************************************************


            string S1 = "Mohammed Abu-Hadhoud";

            Console.WriteLine(S1.Length);

            //this will take 5 characters staring position 2
            Console.WriteLine(S1.Substring(2, 5));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(3, "KKKK"));
            Console.WriteLine(S1.Replace("m", "*"));
            Console.WriteLine(S1.IndexOf("m"));
            Console.WriteLine(S1.Contains("m"));
            Console.WriteLine(S1.Contains("x"));
            Console.WriteLine(S1.LastIndexOf("m"));

            string S2 = "Ali,Ahmed,Khalid";

            string[] NamesList = S2.Split(',');

            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);

            string S3 = "  Abu-Hadhoud  ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());
            //****************************************************

            string firstName = "Mohammed";
            string lastName = "Abu-Hadhoud";
            string code = "107";

            //You shold use $ to $ to identify an interpolated string 
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            Console.WriteLine(fullName);
            Console.WriteLine(status.maryed);

            //****************************************************
            Console.WriteLine("Enter username?");

            string userName = Console.ReadLine();
            Console.WriteLine("Enter your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Username is: " + userName);
            Console.WriteLine("Age is: " + age);

            int mo = 10;
            mo >>= 2;
                Console.WriteLine(mo);
            //****************************************************
            //****************************************************
            //****************************************************
            //****************************************************
            //****************************************************

            Console.ReadKey();
        }
    }
}
