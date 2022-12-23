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

		enum Cnt
		{
			one,
			two,
			three,
			four
		}

		
		public  void TestRefParams() 
        {
         
			Console.WriteLine("Считаем: ", Cnt.two);
			Console.ReadKey();
        }

		public void Main(string[] args)
		{


			TestRefParams();

			var (pet, age) = ("Вольт", 12);

			int[,] array0 = { { 1, 2, 3 }, { 5, 6, 7 } };
			Console.WriteLine(array0.Length);

			int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };

			foreach (var ch in array)
			{
				Console.WriteLine(array.GetUpperBound(1));
			}


			Console.WriteLine("Введите своё имя");

			var name = Console.ReadLine();
			Console.WriteLine("Ваше имя по буквам: ");

			foreach (var ch in name)
			{
				Console.Write(ch + " "); // <-- Не переносим на след строку 
			}

			Console.WriteLine("\nПоследняя буква вашего имени: {0}", name[name.Length - 1]);
			Console.WriteLine("\nПоследняя буква вашего имени: {0}", name.Length);


			Console.ReadKey();

		}
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

	enum TurnDirection
	{
		None = 0,
		Left,
		Right
	}

	class Car
	{
		private double Fuel;

		private int Mileage;

		private string color;

		private TurnDirection turn;

		public Car()
		{
			Fuel = 50;
			Mileage = 0;
			color = "White";
		}

		private void Move()
		{
			// Move a kilometer
			Mileage++;
			Fuel -= 0.5;
		}

		private void Turn(TurnDirection direction)
		{
			turn = direction;
		}

		public void FillTheCar()
		{
			Fuel = 50;
		}

		public string GetColor()
		{
			return color;
		}

		public void ChangeColor(string newColor)
		{
			if (color != newColor)
				color = newColor;
		}

		public bool IsTurningLeft()
		{
			return turn == TurnDirection.Left;
		}

		public bool IsTurningRight()
		{
			return turn == TurnDirection.Right;
		}
	}

	class User
	{
		private int age;
		public int Age
		{
			get
			{
				return age;
			}

			set
			{
				if (value < 18)
				{
					Console.WriteLine("Возраст должен быть не меньше 18");
				}
				else
				{
					age = value;
				}
			}
		}


		private string login;
		public string Login
		{
			get
			{
				return login;
			}

			set
			{
				if (value.Length < 3)
				{
					Console.WriteLine("Логин должен быть длиной от 3 символов");
				}
				else
				{
					login = value;
				}
			}
		}

		


		private string email;
		public string Email
		{
			get
			{
				return email;
			}

			set
			{
				if (!value.Contains("@"))
				{
					Console.WriteLine("Неверный формат адреса электронной почты");
				}
				else
				{
					email = value;
				}
			}

	
		}
}
