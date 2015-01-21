using System;

class Program
{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Birthday (yyyy.mm.dd) : ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            int age = today.Year - birthDay.Year;
            birthDay = new DateTime(today.Year, birthDay.Month, birthDay.Day);
            if (today < birthDay)
                age = age - 1;
            Console.WriteLine("You are {0} years old", age);
            Console.WriteLine("After 10 years you will be {0} years old", (age + 10));
        }
}
