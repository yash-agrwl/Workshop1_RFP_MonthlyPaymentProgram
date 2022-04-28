using System;

namespace MonthlyPayment
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Monthly Payment Program.\n");

            double principle, year, annualInterestRate;

            Console.Write("Enter principle loan amount: ");
            principle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter how many years to make payment: ");
            year = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the rate of interest per year: ");
            annualInterestRate = Convert.ToDouble(Console.ReadLine());

            double months = 12 * year; // Calculating number of months.
            double monthlyInterestRate = annualInterestRate / (12 * 100); // Calculating monthly interest.

            // Applying formula to calculate monthly payment.
            double monthlyPayment = (principle * monthlyInterestRate) / (1 - Math.Pow(1 + monthlyInterestRate, -months)); 

            Console.WriteLine($"\nThe Monthly Payment you have to make over {year} years to pay off a {principle} principle loan amount is: {Math.Round(monthlyPayment,2)}");
        }
    }
}
