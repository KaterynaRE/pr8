using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stru2
{
	struct ComplexNumber
	{
		public double ValidNumber;
		public double ImaginaryNumber;

		public ComplexNumber(double vP, double iP)
		{
			ValidNumber = vP;
			ImaginaryNumber = iP;
		}
		public override string ToString()
		{
			if (ImaginaryNumber >= 0)
				return $"{ValidNumber} + {ImaginaryNumber}i";
			else
				return $"{ValidNumber} - {Math.Abs(ImaginaryNumber)}i";
		}

		public static ComplexNumber AddNum(ComplexNumber obj1, ComplexNumber obj2)
		{
			double sumReal = obj1.ValidNumber + obj2.ValidNumber;
			double sumImaginary = obj1.ImaginaryNumber + obj2.ImaginaryNumber;
			ComplexNumber sum = new ComplexNumber(sumReal, sumImaginary);
			return sum;
		}

		public static ComplexNumber MinusNum(ComplexNumber obj1, ComplexNumber obj2)
		{
			double mReal = obj1.ValidNumber - obj2.ValidNumber;
			double mImaginary = obj1.ImaginaryNumber - obj2.ImaginaryNumber;
			ComplexNumber minus = new ComplexNumber(mReal, mImaginary);
			return minus;
		}

		//(3 + 4i) · (2 - 5i) = (3·2 - 3·5i) + (4·2i - 4·5i2) = 6 - 15i + 8i + 20 = 26 - 7i
		public static ComplexNumber Multiplication(ComplexNumber obj1, ComplexNumber obj2)
		{
			double multReal = (obj1.ValidNumber * obj2.ValidNumber) - (obj1.ImaginaryNumber * obj2.ImaginaryNumber);
			double myltImaginary = (obj1.ValidNumber * obj2.ImaginaryNumber) + (obj1.ImaginaryNumber * obj2.ValidNumber);
			ComplexNumber mylt = new ComplexNumber(multReal, myltImaginary);
			return mylt;
		}

		public static ComplexNumber Division(ComplexNumber obj1, ComplexNumber obj2)
		{
			double divisor = (obj2.ValidNumber * obj2.ValidNumber) + (obj2.ImaginaryNumber * obj2.ImaginaryNumber);
			double divReal = ((obj1.ValidNumber * obj2.ValidNumber) + (obj1.ImaginaryNumber * obj2.ImaginaryNumber)) / divisor;
			double divImaginary = ((obj2.ValidNumber * obj1.ImaginaryNumber) - (obj1.ValidNumber * obj2.ImaginaryNumber)) / divisor;
			ComplexNumber result = new ComplexNumber(divReal, divImaginary);
			return result;
		}
		

	}
}
