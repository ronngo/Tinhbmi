using System;

namespace TinhBMI1
{
    class Program
    {
        static void Main(string[] args)
        {
			double height;
			double weight;
			double bmi;
			//Chiều cao: cm
			//Cân nặng: kg
			Console.WriteLine("Nhap chieu cao : ");
			height = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Nhap can nang : ");
			weight = Convert.ToDouble(Console.ReadLine());
			height = height / 100;
			bmi = weight / (height * height);
			Console.WriteLine("BMI cua ban la:{0}", Math.Round(bmi, 4));
			if (bmi < 18.5)
				Console.WriteLine("Gay ");
			else if (bmi >= 18.5 && bmi < 25)
				Console.WriteLine("Binh thuong");
			else if (bmi >= 25 && bmi < 30)
				Console.WriteLine("thua can");
			else if (bmi >= 30)
				Console.WriteLine("beo phi");

		}
	}
}