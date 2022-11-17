using System;
using System.Net.Security;

Collection list = new Collection();

int[] passIntVal = { (int)EnumForTeacherStudents.Elev, (int)EnumForTeacherStudents.Lærer, (int)EnumForTeacherStudents.Fag };

List<List<object>> returnedList = list.ListCreation();

bool tryAgain = true;

while (tryAgain)
{

	Console.WriteLine
	("Vælg:\n1) Søg efter lærer.\n2) Søg efter elev.\n3) Søg efter fag.\n\ntryk 1, 2 eller 3.");


	string stringInput = Console.ReadLine();

	bool canParseToInt = Int32.TryParse(stringInput, out int userInput);

	if (passIntVal.Contains(userInput) && canParseToInt)
	{
        string? ChoosenEnumValue = Enum.GetName(typeof(EnumForTeacherStudents), userInput);
		string[]? showAllOptions = null;
        string[] ShowResult = null;
        string searchValue;


        if (userInput == 1)
		{
			showAllOptions = list.GetOptions(ChoosenEnumValue);
		}
		else if (userInput == 2)
		{
			showAllOptions = list.GetOptions(ChoosenEnumValue);
		}
		else if (userInput == 3)
		{
			showAllOptions = list.GetOptions(ChoosenEnumValue);
		}
		

        Console.Clear();

		Console.WriteLine($"Her er de forskellige muligheder indenfor {ChoosenEnumValue}\n");
		try
		{
			if (showAllOptions == null)
			{
				throw new("Ingen valg tilgængelig :(. Prøv igen senere");
			}
			for (int i = 0; i < showAllOptions.Length; i++)
			{
				Console.WriteLine($"--{showAllOptions[i]}--");
			}
        Console.WriteLine($"\nSøg efter {ChoosenEnumValue}");
        searchValue = Console.ReadLine();
			Console.Clear();

			if (ChoosenEnumValue == "Lærer")
			{
				ShowResult = (new TeacherStudentSubject(new GetTeachers(), returnedList, ChoosenEnumValue, searchValue).result);
                if (ShowResult == null)
                {
                    throw new("Kunne ikke finde hvad du søgte efter. Prøv igen");
                }
                for (int i = 0; i < ShowResult.Length; i++)
				{
					Console.WriteLine(ShowResult[i]);
				}
                Console.ReadKey();
                Console.Clear();
            }
            else if (ChoosenEnumValue == "Elev")
            {
                ShowResult = (new TeacherStudentSubject(new GetStudents(), returnedList, ChoosenEnumValue, searchValue).result);

                if (ShowResult == null)
                {
                    throw new("Kunne ikke finde hvad du søgte efter. Prøv igen");
                }
                for (int i = 0; i < ShowResult.Length; i++)
                {
                    Console.WriteLine(ShowResult[i]);
                }
                Console.ReadKey();
                Console.Clear();
            }
            else if (ChoosenEnumValue == "Fag")

            {
                ShowResult = (new TeacherStudentSubject(new GetTeachers(), returnedList, ChoosenEnumValue, searchValue).result);

				if (ShowResult == null)
				{
					throw new("Kunne ikke finde hvad du søgte efter. Prøv igen");
				}
                for (int i = 0; i < ShowResult.Length; i++)
                {
					//Console.WriteLine($"-------------------------------------------------\nDu søgte efter: {searchValue}");
                    Console.WriteLine(ShowResult[i]);
                }
				Console.ReadKey();
				Console.Clear();
            }
			
        }

        catch (Exception exception)

        {
			Console.WriteLine($"Fejl: {exception.Message}");
			Console.ReadKey();
			Console.Clear();
        }
    }

	else
	{
		Console.WriteLine("Dit valg er ikke gyldigt. Tryk for at prøve igen");
		Console.ReadKey();
		Console.Clear();
	}
};



//string searching = "Clientsideprogrammering";
//string[] studentNames = list.StudentSearch(returnedList, searching);
//string[] teacher = list.TeacherSearch(returnedList, searching);
//string[] subjects = list.SubjectSearch(returnedList, searching);