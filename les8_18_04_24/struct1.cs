using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace str1
{
	struct Fraction
	{
		public int Numerator;
		public int FractionDenominator;

		public Fraction(int numP, int deNumP)
		{
			this.Numerator = numP;
			this.FractionDenominator = deNumP;
		}

		public override string ToString()
		{
			return $"{Numerator}/{FractionDenominator}";
		}

		public void SimplifyFraction()
		{
			int a = this.Numerator;
			int b = this.FractionDenominator;

			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}

			int gcd = a;
			this.Numerator /= gcd;
		    this.FractionDenominator /= gcd;
		}
			
		public void AddFraction(int otherNumerator, int otherDenominator)
		{
			int sumNumerator;
			int sumDenominator;

			if (this.FractionDenominator != otherDenominator)
			{
				int numerator1 = this.Numerator * otherDenominator;
				int denominator1 = this.FractionDenominator * otherDenominator;

				int numerator2 = otherNumerator * this.FractionDenominator;
				int denominator2 = otherDenominator * this.FractionDenominator;

				sumNumerator = numerator1 + numerator2;
				sumDenominator = denominator1;
			}
			else
			{
				sumNumerator = this.Numerator + otherNumerator;
				sumDenominator = otherDenominator;
			}
			this.Numerator = sumNumerator;
			this.FractionDenominator = sumDenominator;
			SimplifyFraction();
			Console.WriteLine($"Result: {this.Numerator}/{this.FractionDenominator}");
		}



		public void SubtractionFraction(int otherNumerator, int otherDenominator)
		{
			int sumSubtractionNumerator;
			int sumDenominator;

			if (this.FractionDenominator != otherDenominator)
			{
				int numerator1 = this.Numerator * otherDenominator;
				int denominator1 = this.FractionDenominator * otherDenominator;

				int numerator2 = otherNumerator * this.FractionDenominator;
				int denominator2 = otherDenominator * this.FractionDenominator;

				sumSubtractionNumerator = numerator1 - numerator2;
				sumDenominator = denominator1;
			}
			else
			{
				sumSubtractionNumerator = this.Numerator - otherNumerator;
				sumDenominator = otherDenominator;
			}
			this.Numerator = sumSubtractionNumerator;
			this.FractionDenominator = sumDenominator;

			SimplifyFraction();
			Console.WriteLine($"Result: {this.Numerator}/{this.FractionDenominator}");
		}

	
		public void MultiplicationFractions(int otherNumP, int otherDeNumP)
		{
			this.Numerator *= otherNumP;
			this.FractionDenominator *= otherDeNumP;

			SimplifyFraction();
			Console.WriteLine($"Result : {this.Numerator}/{this.FractionDenominator}");
		}
		public void DivideFractions(int otherNumP, int otherDeNumP)
		{
			this.Numerator *= otherDeNumP;
			this.FractionDenominator *= otherNumP;

			SimplifyFraction();
			Console.WriteLine($"Result : {this.Numerator}/{this.FractionDenominator}");
		}

	}
}
