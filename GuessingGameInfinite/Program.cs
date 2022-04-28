using System;

namespace GuessingGameInfinite
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm genereerib juhuslikku numbrit 1 kuni 10;
			//kasutaja peab numbri ära arvama;
			//kui kasutaja suutis numbri arvata, siis ta on mängu võitnud;
			//katsete arv on piiramatu;
			//*programm genereerib juhuslikku numbrit ühe korra.

			Random rnd = new Random();
			int cpuNumber = rnd.Next(1, 11);
			bool loopActive = true;
			int i = 0;


			while (loopActive)
			{
				Console.WriteLine("Oled valmis?");
				Console.WriteLine("Arva ära, mis number jääb vahemikku 1 kuni 10?");
				int userNumber = Convert.ToInt32(Console.ReadLine());

				if (userNumber == cpuNumber)
				{
					Console.WriteLine("Palju õnne! Oled võitnud.");
					loopActive = false;
				}
				else
				{
					i++;
					Console.WriteLine("Vale number, proovi uuesti!");
					Console.WriteLine($"Oled sisestanud {i} korda vale numbri.");
				}
				Console.WriteLine("Nägemist!");
			}
		}
	}
}
