void ex1()
{
    int attempts = 3;
    bool OK = false;
    while (!OK && attempts > 0)
    {
        Console.WriteLine("Scrie emailul si parola, te rog.\nExemplu: \'email password\'");
        string? input = Console.ReadLine();
        string[] inputSplit = input!.Split(" ");
        if (inputSplit.Length < 2)
        {
            attempts -= 1;
            Console.WriteLine($"Input gresit, ti-au ramas {attempts} incercari.");
        }
        else
        {
            if (!ex1_add(inputSplit[0], inputSplit[1]))
            {
                attempts -= 1;
                Console.WriteLine($"Credentiale gresite, ti-au ramas {attempts} incercari.");
            }
            else
            {
                OK = true;
                Console.WriteLine("Felicitari, te-ai logat cu succes!\n");
            }
        }
    }
    if (attempts == 0)
    { Console.WriteLine("Din pacate nu ti-au mai ramas incercari.\n"); }
}

bool ex1_add(string email, string password)
{
    if (email != "atcalcan@gmail.com" || password != "dotnet")
    {
        return false;
    }
    else
    {
        return true;
    }
}

void ex2()
{
    Console.WriteLine("Scrie un caracter, te rog.\nExemplu: \'x\'");

    bool OK = false;
    char c = '0';
    while (!OK)
    {
        string? input = Console.ReadLine();
        try
        {
            c = Char.Parse(input!);
            Console.WriteLine($"Inputul tau a fost {ex2_add(c)}.\n");
            OK = true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Scrie doar un caracter, te rog.");
            OK = false;
        }

    }
}

string ex2_add(char c)
{
    if ("aeiou".IndexOf(c) >= 0)
    {
        return "o vocala";
    }
    else if ("0123456789".IndexOf(c) >= 0)
    {
        return "o cifra";
    }
    else return "altceva decat o cifra sau o vocala";
}

void ex3()
{
    Console.WriteLine("Scrie doua numere, te rog.\nExemplu: \'1 2\'");
    bool OK = false;
    int x1 = 0;
    int x2 = 0;
    while (!OK)
    {
        string? input = Console.ReadLine();
        string[] inputSplit = input!.Split(" ");
        try
        {
            x1 = Int32.Parse(inputSplit[0]);
            x2 = Int32.Parse(inputSplit[1]);
            Console.WriteLine($"{ex3_add(x1, x2).ToString()}\n");
            OK = true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Te rog introdu doua *numere*.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Te rog introdu *doua* numere.");
        }
    }
}

bool ex3_add(int a, int b)
{
    if (a % 2 == 0 && b % 2 == 0)
    {
        return true;
    }
    else if (a % 2 == 1 && b % 2 == 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void ex4()
{
    Console.WriteLine("Scrie un sir de cuvinte, te rog.\nExemplu: \'cinic minim\'");
    string? input = Console.ReadLine();
    string[] inputSplit = input!.Split(" ");
    Console.WriteLine($"In sirul tau erau {ex4_add(inputSplit)} cuvinte palindrom.\n");
}

int ex4_add(string[] args)
{
    int rezultat = 0;
    foreach (string item in args)
    {
        char[] c1 = item.ToCharArray();
        char[] c2 = new char[c1.Length];
        int i = 0;
        foreach (char c in c1)
        {
            c2[i] = c;
            i++;
        }
        Array.Reverse<char>(c2);
        string string1 = new string(c1);
        string string2 = new string(c2);
        if (string1 == string2)
        {
            rezultat += 1;
        }
    }
    return rezultat;
}


while (true)
{
    Console.WriteLine("Ce exercitiu ai vrea sa vezi?\n1.\tExercitiul 1;\n2.\tExercitiul 2;\n3.\tExercitiul 3;\n4.\tExercitiul 4;");
    bool OK = false;
    int chosenExercise = 0;
    while (!OK)
    {
        string? input = Console.ReadLine();
        try
        {
            chosenExercise = Int32.Parse(input!);
            if (chosenExercise <= 4)
            {
                OK = true;
            }
            else
            {
                Console.WriteLine("Scrie un numar din range-ul oferit, te rog.");
                OK = false;
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("Scrie un numar, te rog.");
            OK = false;
        }

    }
    if (chosenExercise == 0)
    {
        break;
    }
    switch (chosenExercise)
    {
        case 1:
            {
                ex1();
                break;
            }
        case 2:
            {
                ex2();
                break;
            }
        case 3:
            {
                ex3();
                break;
            }
        case 4:
            {
                ex4();
                break;
            }
        default:
            {
                break;
            }

    }
}
Console.ReadKey();