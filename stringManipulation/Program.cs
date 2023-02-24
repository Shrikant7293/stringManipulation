

class Program
{
	public static void Main()
	{
		stringManipulation();

		CalculateConsonent();

		Vowels();

		PrintName();
	}

	// camelCase
	static void stringManipulation()
	{

		// Calculate Length Of Character

		Console.WriteLine("Enter Any String");
		var ch = Console.ReadLine();

		int Stringcounter = 0;

		foreach (var item in ch)
		{
			Stringcounter++;
		}

		Console.WriteLine("Length Of The Character = " + Stringcounter);
	}

	  // PascalCase

	static void CalculateConsonent()
	{
		// Calculate Sapce,Consonent

		Console.WriteLine("Enter Any String");
		var grh = Console.ReadLine();

		int CalculateSpace = 0;
		int CalculateConsonent = 0;

		foreach (var item in grh)
		{
			if (item == ' ')
			{
				CalculateSpace++;
			}
			if (!(item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' || item == 'A' ||
				item == 'E' || item == 'I' || item == 'O' || item == 'U' || item == ' '))
			{
				CalculateConsonent++;
			}
		}

		Console.WriteLine("Number Of Space In String = " + CalculateSpace);
		Console.WriteLine("Number Of Word In String = " + (CalculateSpace + 1));
		Console.WriteLine("Number Of Consonent In String = " + CalculateConsonent);

	}

	static void Vowels()
	{
		// Calculate Vowels

		Console.WriteLine("Enter Any String");
		var str = Console.ReadLine();

		int VowelCount = 0;

		foreach(var voewl in str)
		{
			if(voewl=='a'||voewl=='e'|| voewl=='i'|| voewl=='o'|| voewl=='u'|| 
               voewl == 'A' || voewl == 'E' || voewl == 'I' || voewl == 'O' || voewl == 'U')
			{
				VowelCount++;
			}
			
		}

		Console.WriteLine("Number Of Vowels = " + VowelCount);
	}

	static void PrintName()
	{
		//  Print FullName

		string LastName, FirstName, MiddleName;

		Console.WriteLine("Enter Last Name");
		LastName=Console.ReadLine();

		Console.WriteLine("Enter First Name");
		FirstName=Console.ReadLine();

		Console.WriteLine("Enter Middle Name");
		MiddleName=Console.ReadLine();

		string FullName = LastName + " " + FirstName + " " + " " + MiddleName;

		Console.WriteLine(FullName);
	}
}
