namespace inventory_management_system
{
	internal class Program
	{

		public static string[,] Inventory = new string[40, 3];
		static int Index = 0;


		static void Main(string[] args)
		{

			// Welcome User
			// Add product (Id,Name ,Quantity, price )
			// view all product
			// up date product
			// Exit
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Welcome to the inventory system :) \n ");
			Console.ForegroundColor = ConsoleColor.White;

			int UserChoice = 0;


			while (true)
			{
				do
				{

					Console.WriteLine("1, Add product");
					Console.WriteLine("2, Update product");
					Console.WriteLine("3, View product");
					Console.WriteLine("4, Exit");
					Console.ForegroundColor = ConsoleColor.Yellow;

					Console.Write("Please Choice Numbers --- > ");
					Console.ForegroundColor = ConsoleColor.White;


				} while (!int.TryParse(Console.ReadLine(), out UserChoice) || UserChoice > 4 || UserChoice == 0);

				switch (UserChoice)
				{
					case 1:
						// Add product (Id,Name ,Quantity, price )
						Addproduct();
						break;
					case 2:
						// up date product
						Update();
						break;
					case 3:

						// view all product
						ViewProduct();
						break;
					case 4:
						// Exit
						Console.Beep();
						Environment.Exit(0);

						break;
					default:
						break;
				}
			}

		}


		public static void Addproduct()
		{
			if (Index < 40 || Index < 0)
			{
				string Name;
				do
				{
					Console.Write("Please Enter product Name ");
					Name = Console.ReadLine();


				} while (string.IsNullOrEmpty(Name));


				string Quantity;
				do
				{
					Console.Write("Please Enter product Quantity ");

					Quantity = Console.ReadLine();


				} while (string.IsNullOrEmpty(Quantity));

				string Price;
				do
				{
					Console.Write("Please Enter product Price ");

					Price = Console.ReadLine();


				} while (string.IsNullOrEmpty(Price));



				if (Name != null && Quantity != null && Price != null)
				{
					Inventory[Index, 0] = Name;
					Inventory[Index, 1] = Quantity;
					Inventory[Index, 2] = Price;
					Index++;
				}

				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Add Successfully \n");
				Console.ForegroundColor = ConsoleColor.White;
			}
		}

		public static void ViewProduct()
		{
			Console.Clear();

			if (Inventory is not null)
			{
				for (int i = 0; i < Index; i++)
				{
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine($"PeoductId {i + 1}, Product Nmae {Inventory[i, i]},  Quantity {Inventory[i, 1]},Price {Inventory[i, 2]}");
					Console.ForegroundColor = ConsoleColor.White;
				}
			}
		}


		public static void Update()
		{
			Console.Clear();

			if (Inventory is not null)
			{
				Console.WriteLine("Please Enter Id product: ");

				int IdProduct = int.Parse(Console.ReadLine());

				Console.WriteLine(" what is change ! ");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("===============================");
				Console.WriteLine("1, Name ");
				Console.WriteLine("2, quantity ");
				Console.WriteLine("3, Price ");

				Console.ForegroundColor = ConsoleColor.White;

				Console.Write("Please Choice Numbers ---> ");
				int Numbers = int.Parse(Console.ReadLine());

				if (Numbers == 1)
					Console.Write("Enter New Name === > ");
				else if (Numbers == 2)
					Console.Write("Enter New Quentity === > ");
				else
					Console.Write("Enter New Price === > ");


				string New = Console.ReadLine();
				if (Numbers == 1)
					Inventory[IdProduct, 0] = New;
				else if (Numbers == 2)
					Inventory[IdProduct, 1] = New;
				else
					Inventory[IdProduct, 2] = New;

				for (int i = 0; i < 1; i++)
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Blue;

					Console.WriteLine($"NewProduct ======== >PeoductId {i + 1}, Product Nmae {Inventory[IdProduct, i]},  Quantity {Inventory[IdProduct, 1]},Price {Inventory[IdProduct, 2]}\n");
					Console.ForegroundColor = ConsoleColor.White;

				}
				Console.ForegroundColor = ConsoleColor.Green;

				Console.WriteLine("Successfully ");
				Console.ForegroundColor = ConsoleColor.White;





			}
		}



	}
}
