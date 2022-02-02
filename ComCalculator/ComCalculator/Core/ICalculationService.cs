using System;
using System.Collections.Generic;
using System.Text;

namespace ComCalculator.Core
{
	public interface ICalculationService
	{
		double ToCalculate(params string[] values);
		double ToCalculate(double newValue, double oldValue, double coefitient);

		int ConvertToInt(string value);
		double ConvertToDouble(string value);
	}
}
