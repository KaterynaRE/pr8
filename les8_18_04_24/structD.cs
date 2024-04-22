using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strD
{
	struct DayOfBirthday
	{
		public DateTime dateBirthday;

		public DayOfBirthday(DateTime date)
		{
			dateBirthday = date;
		}

		public void WasDayOfWeekBerthday(DateTime dateP)
		{
			DateTime dateUser = dateP;

			int userMonth = dateUser.Month;
			string dayOfWeek = dateUser.DayOfWeek.ToString();
			switch (userMonth)
			{
				case 1:
				case 2:
				case 12:
					Console.WriteLine($"Winter  {dayOfWeek}");
					break;
				case 3:
				case 4:
				case 5:
					Console.WriteLine($"Spring  {dayOfWeek}");
					break;
				case 6:
				case 7:
				case 8:
					Console.WriteLine($"Summer {dayOfWeek}");
					break;
				case 9:
				case 10:
				case 11:
					Console.WriteLine($"Autumn {dayOfWeek}");
					break;
			}

		}

		public void WhenDayOfWeekBerthday(DateTime dateP)
		{
			DateTime dateUser = dateP;
			int userMonth = dateUser.Month;
			string dayOfWeek = dateUser.DayOfWeek.ToString();
			switch (userMonth)
			{
				case 1:
				case 2:
				case 12:
					Console.WriteLine($"Winter  {dayOfWeek}");
					break;
				case 3:
				case 4:
				case 5:
					Console.WriteLine($"Spring  {dayOfWeek}");
					break;
				case 6:
				case 7:
				case 8:
					Console.WriteLine($"Summer {dayOfWeek}");
					break;
				case 9:
				case 10:
				case 11:
					Console.WriteLine($"Autumn {dayOfWeek}");
					break;
			}

		}

		//короче 
		public DayOfWeek DayOfWeekOfBirth()
		{
			return dateBirthday.DayOfWeek;
		}

		public DayOfWeek DayWeekInYear(int year)
		{
			DateTime BirthdayThisYear = new DateTime(year, dateBirthday.Month, dateBirthday.Day);
			return BirthdayThisYear.DayOfWeek;
		}
		public override string ToString()
		{
			return $"Date of birthday {dateBirthday.ToShortDateString()}";
		}

		public int DaysUntilBirthday(int currentYear)
		{
			DateTime now = DateTime.Now;
			DateTime nextBirthday = new DateTime(currentYear, dateBirthday.Month, dateBirthday.Day);

			if (nextBirthday < now)
			{
				nextBirthday = nextBirthday.AddYears(1);
			}
			TimeSpan difference = nextBirthday - now;
			return difference.Days;
		}



	}

}
