using System; 

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string check;
            do
            {
                Console.WriteLine("Kullanıcı Adı : ");
                string userName = Console.ReadLine();
                Console.WriteLine("Şifrenizi Giriniz : ");
                string password = Console.ReadLine();

                string userNameSystem = "Reis";
                string passwordSystem = "onur";
                
                if (userName == userNameSystem && password == passwordSystem)
                    Console.WriteLine("password ve kullanıcı adı dogru...");
                    Console.WriteLine("Hoşgeldin Reis... ");

                if (userName != userNameSystem && password == passwordSystem)
                    Console.WriteLine("sadece username hatalı");

                if (userName == userNameSystem && password != passwordSystem)
                    Console.WriteLine("sadece password hatalı");

                if (userName != userNameSystem && password != passwordSystem)
                    Console.WriteLine("hem password hem de username hatalıdır");



                Console.WriteLine("Devam etmek için d ye basın, çıkmak için herhangi bir tuşa basınız.");
                check = Console.ReadLine();
                
            } while (check == "d"); 

            Console.Read();
        }
    }
}
