using System;
using Figgle;

namespace NumberGuessGame
{
	class Program
	{
		static int numberOfGuesses = 0;
		static int randomNumber = new Random().Next(1, 100);
		static int guessedNumber = 0;
		
		static void Main(string[] args)
		{
			Setup();
		}

		static void Setup()
		{
			Console.WriteLine(FiggleFonts.Standard.Render("Number Guess!\n"));
			Console.WriteLine("Press 'SPACE' to play...");
			while (Console.ReadKey().Key != ConsoleKey.Spacebar) { }

			Console.Clear();
			Game();
		}

		static void Game()
		{
			Console.WriteLine("Enter a Guess:");
			Console.Write("> ");
			string input = Console.ReadLine();
			if (int.TryParse(input, out guessedNumber))
			{
				if (numberOfGuesses <= 10)
				{
					if (guessedNumber == randomNumber)
					{
						++numberOfGuesses;
						Console.Clear();
						Console.WriteLine(FiggleFonts.Standard.Render("Congrats, You Won!"));
						Console.WriteLine("Guesses used: " + numberOfGuesses);
						Console.WriteLine("Restart? (Y)es");
						while (Console.ReadKey().Key != ConsoleKey.Y) { }
						Console.Clear();
						randomNumber = new Random().Next(1, 100);
						numberOfGuesses = 0;
						Game();
					}
					else if (guessedNumber == 420)
					{
						Console.WriteLine(easteregg);
						Console.Read();
						Console.Clear();
						Game();
					}
					else
					{
						++numberOfGuesses;
						if (guessedNumber > randomNumber)
						{
							if (guessedNumber >= 1 && guessedNumber <= 100)
							{
								Console.Clear();
								Console.WriteLine("Too high! Try Again");
								Game();
							}
							else
							{
								Console.Clear();
								Console.WriteLine("Invalid input for guess, please enter again");
								Game();
							}
						}
						else if (guessedNumber < randomNumber)
						{
							if (guessedNumber >= 1 && guessedNumber <= 100)
							{
								Console.Clear();
								Console.WriteLine("Too low! Try Again");
								Game();
							}
							else
							{
								Console.Clear();
								Console.WriteLine("Invalid input for guess, please enter again");
								Game();
							}
						}
					}
				} 
				else
				{
					Console.Clear();
					Console.WriteLine(FiggleFonts.Standard.Render("You Lose!"));
					Console.WriteLine("The number was: " + randomNumber);
					Console.WriteLine("Restart? (Y)es");
					while (Console.ReadKey().Key != ConsoleKey.Y) { }
					Console.Clear();
					randomNumber = new Random().Next(1, 100);
					numberOfGuesses = 0;
					Game();
				}
			}
			else
			{
				Console.Clear();
				Console.WriteLine("Invalid input for guess, please enter again");
				Game();

			}
		}

		static string easteregg =
			"                     .                          \n" +
			"                     M                          \n" +
			"                    dM                          \n" +
			"                    MMr                         \n" +
			"                   4MMML                  .     \n" +
			"                   MMMMM.                xf     \n" +
			"   .              \"MMMMM		.MM-     \n" +
			"    Mh..          +MMMMMM            .MMMM      \n" +
			"    .MMM.         .MMMMML.          MMMMMh      \n" +
			"     )MMMh.        MMMMMM         MMMMMMM  \n" +
			"      3MMMMx.     'MMMMMMf      xnMMMMMM\"       \n" +
			"        *MMMMMx    \"MMMMM\\    .MMMMMMM=         \n" +
			"         *MMMMMh   \"MMMMM\"   JMMMMMMP           \n" +
			"           MMMMMM   3MMMM.  dMMMMMM	      .\n" +
			"            MMMMMM  \"MMMM.MMMMM(        .nnMP\"\n" +
			"=..          *MMMMx  MMM\"  dMMMM\"    .nnMMMMM*  \n" +
			"  \"MMn...     'MMMMr 'MM MMM\"   .nMMMMMMM*\"   \n" +
			"   \"4MMMMnn..   * MMM  MM MMP\"  .dMMMMMMM\"\"     \n" +
			"        *PMMMMMMhn. *x > M  .MMMM**\"\"           \n" +
			"           \"\"**MMMMhx/.h/ .=*\"                  \n" +
			"                    .3P\" % ....\n" +
			"                  nP\"     \"*MMnx       ";

	}
}
