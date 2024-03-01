namespace AtmUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atm myAtm = new Atm();
            myAtm.Login();
            do
            {

                if (myAtm.isLoggedIn)
                {
                    myAtm.Transaction();
                    Console.WriteLine("Do you want to take any other action? (y/n)");
                    string continueOption = Console.ReadLine();
                    if (continueOption.ToLower() != "y")
                    {
                        myAtm.isLoggedIn = false;
                    }
                }


            } while (myAtm.isLoggedIn);
            Console.WriteLine("Exiting... Have a nice day!");

        }
    }
}
