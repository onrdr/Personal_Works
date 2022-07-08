 
char[] sessizler =
{
    'b','ç','c','d','f','g','ğ','h','j','k','l','m','n','p','r','s','ş','t','v','y','z'
};

char[] sesliler =
{
    'a','e','ı','i','u','ü','o','ö'
};

char[] wordToGuess = GetFirstUserWord().ToCharArray();
Console.Clear();
List<char> charsToCompare = GetSecondUserLetter();
char[] finalSentence = new char[wordToGuess.Length];

Check();
Timer();

Console.Write("\nDoğru Kelime : ");

foreach (var item in wordToGuess)
{
    Console.Write($"{item} ");
}

Console.ReadKey();


void Check()
{
    for (int i = 0; i < charsToCompare.Count; i++)
    {
        for (int j = 0; j < wordToGuess.Length; j++)
        {
            if (charsToCompare[i].Equals(wordToGuess[j]))
            {
                finalSentence[j] = charsToCompare[i];
            }
        }
    }

    foreach (char item in finalSentence)
    {
        if (!sesliler.Contains(item) && !sessizler.Contains(item))
        {
            Console.Write("_ ");
        }
        else
        {
            Console.Write($"{item} ");
        }
    }


    Console.WriteLine();
}

string GetFirstUserWord()
{ 
    Console.WriteLine("Enter Your Word");
    return Console.ReadLine().ToLower(); 
}

List<char> GetSecondUserLetter()
{
    int counter = 0;
    List<char> charList = new();
    while (true)
    {
        Console.WriteLine($"{++counter}. Sessiz harfi giriniz");
        char c = Convert.ToChar(Console.ReadLine().ToLower());
        if (sessizler.Contains(c))
            charList.Add(c);
        else
        { 
            Console.WriteLine("Sadece Sessiz harf girin");
            counter--;
        }

        if (counter == 6)
            break; 
    }

    int counter2 = 0;

   while (true)
    {
        Console.WriteLine($"{++counter2}. Sesli harfi giriniz");
        char c = Convert.ToChar(Console.ReadLine());
        if (sesliler.Contains(c))
            charList.Add(c);
        else
        {
            Console.WriteLine("Sadece Sesli harf girin");
            counter2--;
        }

        if (counter2 == 2)
            break;
    }

    return charList;
}

void Timer()
{
    int sayac = 15;
    Console.WriteLine();
    while (sayac > 0)
    { 
        Thread.Sleep(1000);
        Console.Write($"{sayac--} ");
    }

    Console.WriteLine();
}
