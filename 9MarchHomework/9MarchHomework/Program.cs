using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    struct User
    {
        public string Name;
        public float Weight;
        public float DailyWaterIntake;

        public User(string name, float weight)
        {
            Name = name;
            Weight = weight;
            DailyWaterIntake = weight / 20.0f; 
        }
    }

    class WaterData
    {
        public User User { get; set; }
        public Dictionary<string, List<float>> History { get; set; }
    }

    class WaterTracker
    {
        private WaterData waterData = new WaterData();

        public void AddWater(string date, float amount)
        {
            if (waterData.History == null)
            {
                waterData.History = new Dictionary<string, List<float>>();
            }

            if (!waterData.History.ContainsKey(date))
            {
                waterData.History[date] = new List<float>();
            }
            waterData.History[date].Add(amount);
        }

        public void ShowHistory(string fileName)
        {
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                waterData = JsonSerializer.Deserialize<WaterData>(json);

                Console.WriteLine("Water drinking history:");
                foreach (var entry in waterData.History)
                {
                    Console.Write(entry.Key + ": ");
                    foreach (var amount in entry.Value)
                    {
                        Console.Write(amount + " liters, ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No history found.");
            }
        }

        public void SaveData(User user, string fileName)
        {
            waterData.User = user;
            string json = JsonSerializer.Serialize(waterData);

            File.WriteAllText(fileName, json);
            Console.WriteLine("Data saved successfully.");
        }
    }

    static void Main(string[] args)
    {
        string name;
        float weight;
        float amount;
        int choice;
        User user;
        WaterTracker tracker = new WaterTracker();
        string fileName = "userdata.json";

        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.Write("Enter your weight (kg): ");
        weight = float.Parse(Console.ReadLine());

        user = new User(name, weight);

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. I drank water");
            Console.WriteLine("2. View water drinking history");
            Console.WriteLine("3. End the day");
            Console.WriteLine("4. Save data");
            Console.Write("Your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("How many liters of water did you drink today? ");
                    amount = float.Parse(Console.ReadLine());
                    tracker.AddWater(DateTime.Today.ToString("dd.MM.yyyy"), amount);
                    Console.WriteLine("Water intake recorded successfully!");
                    break;
                case 2:
                    tracker.ShowHistory(fileName);
                    break;
                case 3:
                    Console.WriteLine("Ending the day... Goodbye!");
                    break;
                case 4:
                    tracker.SaveData(user, fileName);
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        } while (choice != 3);
    }
}
