namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account accounts = new Account();
            Console.Write("enter Account ID : ");
            accounts.Id=Convert.ToInt32(Console.ReadLine());
            Console.Write("enter Account type : ");
            accounts.AccountType=Console.ReadLine();
            Console.Write("enter Account balance : ");
            accounts.Balance=Convert.ToInt32(Console.ReadLine());

            string details=accounts.GetDetails();
            Console.WriteLine(details); 
            Console.WriteLine("amount to be deducted");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (accounts.Withdraw(amount))
                {
                    Console.WriteLine("New Balance: " + accounts.Balance);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Transaction failed! Not enough balance");
                    Console.WriteLine();
                }

            

        }
    }
}