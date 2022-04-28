using System;

namespace GuessingGameThreeTries
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm genereerib juhuslikku numbrit 1 kuni 10;
			//kasutaja peab numbri ära arvama;
			//kui kasutaja suutis numbri arvata, siis ta on mängu võitnud;
			//katsete arv on 3, kui ei ole suutnud arvata, siis mängu võidab arvuti;
			//*programm genereerib juhuslikku numbrit ühe korra.

			Random rnd = new Random();
			int cpuNumber = rnd.Next(1, 11);
			int i = 0;


			while (i < 3)
			{
				Console.WriteLine("Oled valmis?");
				Console.WriteLine("Arva ära, mis number jääb vahemikku 1 kuni 10?");
				int userNumber = Convert.ToInt32(Console.ReadLine());

				if (userNumber == cpuNumber)
				{
					Console.WriteLine("Palju õnne! Oled võitnud.");
					break;
				}
				else
				{
					i++;
					Console.WriteLine("Vale number!");
					Console.WriteLine($"Oled sisestanud {i} korda vale numbri. Jäänud on {3 - i} katset.");
				}
				Console.WriteLine("Nägemist!");
			}
		}
	}
}
