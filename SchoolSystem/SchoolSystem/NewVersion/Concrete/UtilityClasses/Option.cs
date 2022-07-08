
namespace NewVersion
{
    public static class Option
    {
        public static int GetValidChoice(int maxNumber)
        {
            int choice;
            while (true)
            {
                try
                {
                    Messages.EnterChoice();
                    choice = int.Parse(Console.ReadLine());
                    if (choice <= maxNumber && choice >= 0)
                        return choice;
                    else
                        Messages.Error("Not a valid input !!!\n");
                }
                catch (Exception)
                {
                    Messages.Error("Invalid Input !!!\n");
                }
            }
        }
    }
}
