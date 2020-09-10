using System;
using System.Text;

namespace TinhBMI
{
    class Program
    {
		public double tinh(double height, double weight)
		{
			double bmi;

			height = height / 100;
			bmi = weight / (height * height);
			Console.WriteLine("BMI của bạn là:{0}", Math.Round(bmi, 4));
			if (bmi < 18.5)
				Console.WriteLine("gầy.");
			else if (bmi >= 18.5 && bmi < 25)
				Console.WriteLine("bình thường");
			else if (bmi >= 25 && bmi < 30)
				Console.WriteLine("thừa cân");
			else if (bmi >= 30)
				Console.WriteLine("béo");

			return bmi;
		}
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			double height;
			double weight;
			double bmi;
			Console.WriteLine("Nhập chiều cao : ");
			height = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Nhập cân nặng : ");
			weight = Convert.ToDouble(Console.ReadLine());

			Program n = new Program();
			bmi = n.tinh(height, weight);

		}
	}
}