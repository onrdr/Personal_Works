
    int num, i, control, startNum, endNum;

    Console.Write("\nFind the prime numbers within a range of numbers:\n");
    Console.Write("---------------------------------------------------");
    Console.Write("\n\n");

    Console.Write("Input starting number of range: ");
    startNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input ending number of range : ");
    endNum = Convert.ToInt32(Console.ReadLine());
    Console.Write($"The prime numbers between {startNum} and {endNum} are : \n");

    for (num = startNum; num <= endNum; num++)
    {
        control = 0;

        for (i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                control++;
                break;
            }
        }

        if (control == 0 && num != 1)
            Console.Write($"{num}  ");
    }

Console.ReadLine();
