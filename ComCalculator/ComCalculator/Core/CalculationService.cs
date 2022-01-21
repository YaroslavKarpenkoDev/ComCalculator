using System;
using System.Collections.Generic;
using System.Text;

namespace ComCalculator.Core
{
	public class CalculationService : ICalculationService
	{
		public  int ToCalculate(params int[] values)
		{
			int result = 0;
			foreach (var item in values)
			{
				result += item;
			}
			return result;
		}

		public double ToCalculate(double newValue, double oldValue, double coefitient)
		{
			double result = 0;
			result = (newValue - oldValue) * coefitient;
			return result;
		}

		public int ConvertToInt(string value)
		{
			int.TryParse(value, out int result);
			return result;
		}

		public double ConvertToDouble(string value)
		{
			double.TryParse(value, out double result);
			return result;
		}
	}
}
