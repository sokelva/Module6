using System;

namespace FirstApp
{
	#region 
	//class Pen
	//{
	//	public string color;
	//	public double cost;

	//	// Конструктор 1
	//	public Pen()
	//	{
	//		color = "Черный";
	//		cost = 100;
	//	}

	//	// Конструктор 2
	//	public Pen(string c, int co)
	//	{
	//		color = c;
	//		cost = co;
	//	}
	//}

	//class Human
	//{
	//	// Поля класса
	//	public string name;
	//	public int age;

	//	// Метод класса
	//	public void Greetings()
	//	{
	//		Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
	//	}

	//	// Конструктор 1
	//	public Human()
	//	{
	//		name = "Неизвестно";
	//		age = 20;
	//	}
	//	// Конструктор 2
	//	public Human(string n)
	//	{
	//		name = n;
	//		age = 20;
	//	}
	//	// Конструктор 3
	//	public Human(string n, int a)
	//	{
	//		name = n;
	//		age = a;
	//	}
	//}

	//struct Animal
	//{
	//	// Поля структуры
	//	public string type;
	//	public string name;
	//	public int age;

	//	public Animal(string t, string n, int a)
	//       {
	//		type = t;
	//		name = n;
	//		age = a;

	//	}

	//	// Метод структуры
	//	public void Info()
	//	{
	//		Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
	//	}
	//}
	//class Company
	//{
	//	public string Type = "Банк";
	//	public string Name = "Абсолют";
	//}

	//class Department
	//{
	//	public Company Company;
	//	public City City;
	//}

	//class City
	//{
	//	public string Name = "Санкт-Петербург";
	//}
	#endregion 

	class Program
	{
		//static void Main(string[] args)
		//{
		//Human human = new Human();
		//human.Greetings();

		//human = new Human("Дмитрий");
		//human.Greetings();

		//human = new Human("Дмитрий", 23);
		//human.Greetings();

		//Animal animal = new Animal { type = "Собака", name = "Вольт", age = 4};
		//animal.Info();

		//Console.ReadKey();
		//}

		static void Main(string[] args)
		{
			//var department = GetCurrentDepartment();
		}

		//static Department GetCurrentDepartment()
		//{
		//	// logic
		//	Department department = new Department();

		//	if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
		//	{
		//		Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
		//	}
		//	return department;
		//}
	}

	#region
	//class Bus
	//{
	//	public int? Load = null;

	//	public void PrintStatus()
	//	{
	//		if (Load.HasValue && Load > 0)
	//           {
	//			Console.WriteLine("В автобусе {0} пассажиров", Load.Value);
	//           }
	//           else
	//           {
	//			Console.WriteLine("Автобус пуст!");
	//		}
	//	}
	//}

	//class Rectangle
	//{
	//	int a;
	//	int b;

	//	public Rectangle()
	//	{
	//		a = 6;
	//		b = 4;
	//	}

	//	public Rectangle(int side)
	//	{
	//		a = side;
	//		b = side;
	//	}

	//	public Rectangle(int first, int second)
	//	{
	//		a = first;
	//		b = second;
	//	}

	//	static int Square(int a, int b)
	//	{
	//		return a * b;
	//	}

	//}
	#endregion

	//   class Car
	//{
	//	public double Fuel;

	//	public int Mileage;

	//	public Car()
	//	{
	//		Fuel = 50;
	//		Mileage = 0;
	//	}

	//	public void Move()
	//	{
	//		// Move a kilometer
	//		Mileage++;
	//		Fuel -= 0.5;
	//	}

	//	public void FillTheCar()
	//	{
	//		Fuel = 50;
	//	}
	//}

	class Circle
	{
		public double radius;

		public double Square()
		{
			return radius;
		}

		public double Length()
		{
			return radius;
		}
	}

	class Triangle
	{
		public int a;
		public int b;
		public int c;

		public double Square()
		{
			return a;
		}

		public double Perimeter()
		{
			return a;
		}
	}

	class Square
	{
		public int side;

		public double Square_s()
		{
			double s=0;
			return s;
		}

		public double Perimeter()
		{
			double p = 0;
			return p;
		}
	}
}
