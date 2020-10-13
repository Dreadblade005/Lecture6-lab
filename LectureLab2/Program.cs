/// Lab6  
/// File Name: fraction reducer
/// @author: Dakota Durst
/// Date: October 11, 2020
///
/// Problem Statement: 
/// Define a class called Fraction. This class is used to represent a ratio of two integers. 
///
///
/// Overall Plan:
/// 1) create setters and callers as a baseline
/// 2) allow for the setters to have a user input based on variables assigned later on
/// 3) return math of numerator / denominator 
/// 4) convert fraction to the lowest possible version of itself (gcd)
/// 5) test code 

using System;

namespace LectureLab6
{
	class Program
	{
		public class Fraction
		{
			private int numerator;
			private int denominator;
			//create setters and default values (to allow code to run) if user does not input value
			public Fraction()
			{
				numerator = 0;
				denominator = 1;
			}

			public Fraction(int newNumerator)
			{
				numerator = newNumerator;
				denominator = 1;
			}
			//primary setter
			public Fraction(int newNumerator, int newDenominator)
			{
				SetNumerator(newNumerator);
				SetDenominator(newDenominator);
			}

			//setters
			public void SetNumerator(int newNumerator)
			{
				numerator = newNumerator;
			}

			public void SetDenominator(int newDenominator)
			{
				if (newDenominator != 0)
					denominator = newDenominator;
				else //make sure denominator can't be 0 and if it is set number to 1 instead to block error
					denominator = 1;
			}
			//returners
			public int GetNumerator()
			{
				return numerator;
			}

			public int GetDenominator()
			{
				return denominator;
			}
			//math based methods
			public double GetFractionValue(int numerator, int denominator)
			{
				return (double)numerator / denominator; //returns the value of the numberator 
			}
			public void PrintFraction()
			{
				ReduceFraction();
				Console.Out.WriteLine("The lowest term version of the fraction is: " + numerator + "/" + denominator);
			}

			private void ReduceFraction()
			{
				int n = numerator;
				int d = denominator;

				while (n != 0) //does fraction reduction to get the lowest possible fraction
				{
					int temp = n;
					n = d % n;
					d = temp;
				}

				numerator /= d;
				denominator /= d;
			}
		}
		//main, gets user input for the numerator and denominator runs getfraction and print fraction based on the user inputs.
		static void Main(string[] args)
		{
			int a, b;
			Console.Out.WriteLine("Please enter the numerator of your fraction");

            a = Convert.ToInt32(Console.ReadLine());
			Console.Out.WriteLine("Please enter the denominator of your fraction");
			b = Convert.ToInt32(Console.ReadLine());

			Fraction frac1 = new Fraction(a, b);

			frac1.GetFractionValue(a,b);

			frac1.PrintFraction();

		}
	}
}
	