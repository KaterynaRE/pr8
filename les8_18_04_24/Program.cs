using str1;
using System;
using strD;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stru2;

namespace les8_18_04_24
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Завдання 1
			//Створіть структуру «Дріб». Вона повинна мати поля
			//для зберігання чисельника і знаменника.
			//Реалізуйте наступну функціональність:
			//+ ■ Додавання дробів;
			//+ ■ Віднімання дробів;
			//+ ■ Множення дробів;
			//+ ■ Ділення дробів.

			Fraction fraction1 = new Fraction(2, 4);
			Fraction fraction2 = new Fraction(4, 3);

			Console.WriteLine($"{fraction1.Numerator}/{fraction1.FractionDenominator} +" +
				$" {fraction2.Numerator}/{fraction2.FractionDenominator}");	
			fraction1.AddFraction(fraction2.Numerator, fraction2.FractionDenominator);

			Console.WriteLine();
			Console.WriteLine($"{fraction1.Numerator}/{fraction1.FractionDenominator} *" +
				$" {fraction2.Numerator}/{fraction2.FractionDenominator}");
			fraction1.MultiplicationFractions(fraction2.Numerator, fraction2.FractionDenominator);
			Console.WriteLine();

			Fraction fraction3 = new Fraction(4, 2);
			Fraction fraction4 = new Fraction(3, 4);

			Console.WriteLine($"{fraction3.Numerator}/{fraction3.FractionDenominator} -" +
				$" {fraction4.Numerator}/{fraction4.FractionDenominator}");
			fraction3.SubtractionFraction(fraction4.Numerator, fraction4.FractionDenominator);
			Console.WriteLine();

			Fraction fraction5 = new Fraction(14, 2);
			Fraction fraction6 = new Fraction(3, 4);
			Console.WriteLine($"{fraction5.Numerator}/{fraction5.FractionDenominator} :" +
				$" {fraction6.Numerator}/{fraction6.FractionDenominator}");
			fraction5.DivideFractions(fraction6.Numerator, fraction6.FractionDenominator);



			//Завдання 3
			//Створіть структуру «День народження». Визначте в ній необхідні поля і методи.
			//Реалізуйте наступну функціональність:
			//+ ■ Встановлення дати дня народження;
			//+ ■ Визначення дня тижня, коли народився іменинника;
			//+ ■ Визначення дня тижня у зазначеному році, коли буде день народження.
			//Наприклад, день народження припадає на 1 квітня і нам потрібно дізнатися, який це буде день тижня у 2025 році.
			//Правильна відповідь — вівторок;
			//+ ■ Визначення кількості днів до дня народження

			DayOfBirthday date1 = new DayOfBirthday(new DateTime (1988,11,19));
			Console.WriteLine(date1.ToString());

			date1.WasDayOfWeekBerthday(new DateTime(1988, 11, 19));
			date1.WhenDayOfWeekBerthday(new DateTime(2025, 11, 19));

			DayOfBirthday date2 = new DayOfBirthday(new DateTime(1988, 04, 01));
			Console.WriteLine($"\n{date2.ToString()}");
			Console.WriteLine(date2.DayOfWeekOfBirth());
			Console.WriteLine(date2.DayWeekInYear(2025));

			DayOfBirthday date3 = new DayOfBirthday(new DateTime(1994, 08, 04));
			int daysUntilBirthday = date3.DaysUntilBirthday(DateTime.Now.Year);
			Console.WriteLine($"Days until birthday: {daysUntilBirthday}");


			//Завдання 2
			//Створіть структуру «Комплексне число». Визначте в
			//ній необхідні поля та методи.Реалізуйте наступну функціональність:
			//+ ■ Додавання комплексних чисел;
			//+■ Віднімання комплексних чисел;
			//+■ Множення комплексних чисел;
			//+■ Ділення комплексних чисел


			ComplexNumber num1 = new ComplexNumber(3, 4);
			ComplexNumber num2 = new ComplexNumber(2, -5);
			Console.WriteLine($"\n{num1} and {num2}\n");
			ComplexNumber sum = ComplexNumber.AddNum(num1, num2);
			Console.WriteLine($"Sum: {sum}");

			ComplexNumber minus = ComplexNumber.MinusNum(num1, num2);
			Console.WriteLine($"Minus: {minus}");

			ComplexNumber mylt = ComplexNumber.Multiplication(num1, num2);
			Console.WriteLine($"Mylt num : {mylt}");

			ComplexNumber div = ComplexNumber.Division(num1, num2);
			Console.WriteLine($"Division num : {div}");

		}
	}
}
