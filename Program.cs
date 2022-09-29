// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;


Console.Title = "FirstSolo";
Console.ForegroundColor = ConsoleColor.Blue;
Console.WindowHeight = 40;
//Interaction ahead
Console.WriteLine("Select level\n1:Input Output\n2:Loop\n3:Roll random while\n4:Array\n5:List");
int level = Convert.ToInt32(Console.ReadLine());

Random randomGen = new Random ();//is used in multiple cases

switch (level) //most variables are defined inside each case, as this program is just a test there was no need for maximun efficiency
	{ 
	case 1:
		double num01;//declare variables that will be used
		double num02;

		Console.WriteLine("Write your name");
		string name = Console.ReadLine();

		Console.WriteLine("Whatever you say " + name + "\nYou have a cool name.\n\nYou should input a number...");//a generic comment
		num01 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Now input a second number...");
		num02 = Convert.ToDouble(Console.ReadLine());

		double result = num01 * num02;
		Console.WriteLine("The result of multyplying " + num01 + " and " + num02 +  " is: " + result);

		switch (num01)
			{
				case 1:
					Console.WriteLine("first number is a One");
					break;
				case 2:
					Console.WriteLine("first number is a Two");
					break;
				default:
					Console.WriteLine("your number is not a one or a two");
					break;
		 break;
			}
		break;//end of case 1



	case 2:

		Console.Write("\nLooping... from 0 to 9\n");

		for(int i = 0; i < 10; i++)//do a loop
		{
			Console.Write(i+1+"\n\n");
		}

		break;//end of case 2
		


	case 3:
		int roll = 0;
		int attempts = 0;
		Console.WriteLine("The console will now generate random numbers until it rolls a 20");

		while (roll != 20)
		{
			roll = randomGen.Next(1, 21);//generate random
			Console.WriteLine(roll );
			attempts++;
		}
		Console.WriteLine("Number of attemps: " + attempts);

		break;//end of case 3



	case 4:
		Console.WriteLine("Some of my favourite titles...");

		string[] coolSeries = {"The Good Place", "Sandman", "Steins:Gate", "Name_Of_A_Show"};
		string[] userTitles = new string[4];
		
		for(int i = 0; i < coolSeries.Length; i++)
		{
			Console.WriteLine(i+" "+coolSeries[i]);
		}

		Console.WriteLine("now write your 4 most favourite titles");

		for(int i = 0; i < userTitles.Length; i++)
		{
			userTitles[i] = Console.ReadLine();
		}

		Console.WriteLine("\nThe program will now print your titles alphabetically: ");
		Array.Sort(userTitles);

		foreach (string title in userTitles)
		{

			Console.WriteLine(title);

		}

		break;//end of case 4

	case 5:
		List<string> groceriesList = new List<string>();
		Console.WriteLine("Write what you want to buy, add END when ready");
		string userInput = "";
		float total = 0f;
		while (userInput != "END")
		{
			if(userInput != "END" && userInput != "")
			{ 
				userInput = userInput.ToUpper();
				float price = randomGen.Next(1,100000)/100;
				var listInput = userInput + "  $" + price.ToString();
				total += price;
				groceriesList.Add(listInput);
			}
			userInput = Console.ReadLine();
		}

		Console.WriteLine("Here are the prices:");
		foreach (string strang in groceriesList)
		{
			Console.WriteLine(strang);
		}
		Console.WriteLine("Final Price: $" + total);


		break;

	default:
				Console.WriteLine("Input Error");
		break;//end of default case

	}

Console.WriteLine("Press any key to EXIT");
Console.ReadKey();//ends program

