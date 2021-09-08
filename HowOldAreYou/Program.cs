using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm arvutab kasutaja sünniaasta
            //programm kuvab kasutaja sünniaasta konsoolis

            Console.WriteLine("Kui vana sa oled?");

            //convert string from ReadLine() to int
            int Age = Convert.ToInt32(Console.ReadLine());

            int YearOfBirth = 2021 - Age;

            Console.WriteLine("Sa oled sündinud aastal " + YearOfBirth);
        }
    }
}
