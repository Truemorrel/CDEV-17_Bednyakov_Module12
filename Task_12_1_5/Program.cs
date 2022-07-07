using System;
using System.Threading;

namespace Task_12_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserList users = new UserList();
			User person = new User {Login = "Bob", Name = "Robert", IsPremium = true };
			users.AddUser(person);
			users.AddUser(login: "Ivan1980", name: "Ivan", premium: false);
			users.AddUser(login: "Fox", name: "Laura", premium: true);
			users.AddUser(login: "DG", name: "dolce", premium: true);
			string input;
			do
			{
				Console.Write("Input login or leave blanc and press Enter: ");
				input = Console.ReadLine();
				if (users.IsUserInList(input))
				{
					if (users.IsUserPremium(input))
					{
						Console.WriteLine($"Well done. Get in. Go on.{Environment.NewLine}Wellcome!");
						input = string.Empty;
                    }
                    else
                    {
						ShowAds();
						input = string.Empty;
					}
				}
				else
				{
					if (!string.IsNullOrEmpty(input))
                    {
						Console.WriteLine("Register new login.");
						Console.Write("Tipe new user's name: ");
						string newUserName = Console.ReadLine();
						Console.Write("Tipe new user's password: ");
						string newUserPassword = Console.ReadLine();
						users.AddUser(login: input, name: newUserName, premium: false);
                    }
				}
			}
			while (!string.IsNullOrEmpty( input ));
        }
		
		static void ShowAds()
		{
			Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
			// Остановка на 1 с
			Thread.Sleep(1000);

			Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
			// Остановка на 2 с
			Thread.Sleep(2000);

			Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
			// Остановка на 3 с
			Thread.Sleep(3000);
		}
	}
}
