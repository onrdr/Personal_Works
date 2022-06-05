
GuessGame.Guess();
Console.ReadKey(); 
class GuessGame
{
    public static void Guess()
    {
        Random random = new();
        int numGenerated = random.Next(100);
        int counter = 1;

        while (true)
        {
            Console.WriteLine("Enter your guess #" + counter);
            int numGuessed = Convert.ToInt32(Console.ReadLine());

            if (numGuessed >= 0 || numGuessed < 100)
            {
                if (numGuessed == numGenerated)
                {
                    Console.WriteLine("Bingo! You found it in guess #" + counter);
                    Console.WriteLine("Your score is : " + Point(counter));
                    break;
                }
                else if (numGuessed < numGenerated && counter != 5)
                {
                    Console.WriteLine("Too low. Enter your guess #" + (counter + 1));
                }
                else if (numGuessed > numGenerated && counter != 5)
                {
                    Console.WriteLine("Too high. Enter your guess #" + (counter + 1));
                }
                else
                {
                    Console.WriteLine("You are out of tries! Exiting...");
                    Console.WriteLine($"Your score is : {Point(counter + 1)}");
                    Console.WriteLine($"The number was {numGenerated}");
                    break;
                }
                counter++;
            }
            else
                Console.WriteLine("Out of range 0 - 100");
        }
    }

    public static int Point(int counter)
    {
        switch (counter)
        {
            case 1:
                return 100;
            case 2:
                return 80;
            case 3:
                return 60;
            case 4:
                return 40;
            case 5:
                return 20;
            default:
                break;
        }
        return 0;
    }
}


