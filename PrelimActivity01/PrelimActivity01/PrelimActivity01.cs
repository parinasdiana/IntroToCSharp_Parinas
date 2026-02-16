using System;

namespace CodacLogistics
{
	class Program
	{
		static void Main(string[] args)
		{
			// --- TASK 1: Driver Profile & Distance Validation ---
			Console.WriteLine("=== CODAC LOGISTICS FUEL AUDIT ===");
			Console.Write("Enter Driver's Full Name: ");
			string driverName = Console.ReadLine(); // string used for textual data

			Console.Write("Enter Weekly Fuel Budget: ");
			decimal fuelBudget = decimal.Parse(Console.ReadLine()); // decimal used for financial accuracy

			double totalDistance = 0;
			while (totalDistance < 1.0 || totalDistance > 5000.0)
			{
				Console.Write("Enter Total Distance Traveled (km): ");
				totalDistance = double.Parse(Console.ReadLine());

				if (totalDistance < 1.0 || totalDistance > 5000.0)
				{
					Console.WriteLine("Error: Distance must be between 1.0 and 5000.0.");
				}
			}

			// --- TASK 2: Fuel Expense Tracking ---
			decimal[] fuelExpenses = new decimal[5]; // 1D Array to hold 5 days of fuel data
			decimal totalFuelSpent = 0;

			for (int i = 0; i < 5; i++)
			{
				Console.Write($"Enter fuel cost for Day {i + 1}: ");
				fuelExpenses[i] = decimal.Parse(Console.ReadLine());
				totalFuelSpent += fuelExpenses[i]; // Accumulate total
			}

			// --- TASK 3: Performance Analysis --
			decimal averageDailyExpense = totalFuelSpent / 5; // Calculate average
			double efficiency = totalDistance / (double)totalFuelSpent; // Cast to double for calculation
			string rating = "";

			if (efficiency > 15) { rating = "High Efficiency"; }
			else if (efficiency >= 10) { rating = "Standard Efficiency"; }
			else { rating = "Low Efficiency / Maintenance Required"; }

			bool isUnderBudget = totalFuelSpent <= fuelBudget; // Boolean check for budget status

			// --- TASK 4: The Audit Report ---
			Console.WriteLine("\n--- AUDIT REPORT ---");
			Console.WriteLine($"Driver Name: {driverName}");
			Console.WriteLine($"Total Distance: {totalDistance} km");
			Console.WriteLine($"Total Fuel Spent: {totalFuelSpent:C}");
			Console.WriteLine($"Average Daily Expense: {averageDailyExpense:C}");
			Console.WriteLine($"Efficiency Rating: {rating}");
			Console.WriteLine($"Stayed Under Budget: {isUnderBudget}");

			Console.WriteLine("\nPress any key to exit...");
			Console.ReadKey();
		}
	}
}
