



Random random = new();
List<int> randomNumberInArrayList = new(); 
int randomNumber;

while (randomNumberInArrayList.Count < 5)
{
    randomNumber = random.Next(10);
    if (!randomNumberInArrayList.Contains(randomNumber))
        randomNumberInArrayList.Add(randomNumber);
    if (randomNumberInArrayList[0] == 0)
        randomNumberInArrayList.Remove(0);
}
int generatedNumber = 0;
foreach (int i in randomNumberInArrayList)
{
    generatedNumber = generatedNumber * 10 + i; 
}
getResult(generatedNumber);

Console.ReadLine();


static void getResult(int randomNumber)
{
    // Console.WriteLine($"Generated Number is : {randomNumber}");

    List<int> randomNumberArrayList = numberToArrayList(randomNumber);
    int correctDigitCounter = 0;
    int wrongDigitCounter = 0;
    int userTryCounter = 1;
    int userNumber;

    while (true)
    {
        userNumber = getUserNumber();
        List<int> userNumberArrayList = numberToArrayList(userNumber);
        if (userNumberArrayList.Count != 5 || userNumberArrayList[0] == 0)
        {
            Console.WriteLine("Please enter 5 digits only !!!");
        }
        else if (userNumber == randomNumber)
        {
            Console.WriteLine($"Bingo !!! You found it in your try #{userTryCounter}\n");
            break;
        }
        else
        {
            for (int i = 0; i < userNumberArrayList.Count; i++)
            {
                for (int j = 0; j < randomNumberArrayList.Count; j++)
                {
                    bool flag = userNumberArrayList[i].Equals(randomNumberArrayList[j]);
                    if (i == j && flag)
                    {
                        correctDigitCounter++;
                    }
                    else if (i != j && flag)
                    {
                        wrongDigitCounter++;
                        break;
                    }
                }
            }
            Console.WriteLine($"Right place : {correctDigitCounter} --- Wrong Place : {wrongDigitCounter}\n");
            correctDigitCounter = 0;
            wrongDigitCounter = 0;
            userTryCounter++;
        }
    }
}

static int getUserNumber()
{
    int userNumber;
    while (true)
    { 
        try
        {
            Console.WriteLine("================================");
            Console.WriteLine("Please enter a 5 digit number : ");
            userNumber = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Input");
        }
    }

    return userNumber;
}

static List<int> numberToArrayList(int number)
{
    int temp = number;
    List<int> array = new();
    do
    {
        array.Add(temp % 10);
        temp /= 10;
    } while (temp > 0);

    array.Reverse(); 
    return array;
}
