namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<Account> accounts = new List<Account>() {
            //new Account(){Id=0,AccountType="savings",Balance=1000},
            //new Account(){Id=2,AccountType="savings",Balance=4000},
            //new Account(){Id=4,AccountType="current",Balance=10000},
            //new Account(){Id=1,AccountType="savings",Balance=2000},
            //new Account(){Id=9,AccountType="savings",Balance=10000},
            //new Account(){Id=8,AccountType="current",Balance=3000},
            //new Account(){Id=7,AccountType="savings",Balance=12000},
            //new Account(){Id=6,AccountType="savings",Balance=21000},
            //new Account(){Id=5,AccountType="current",Balance=51000},
            //new Account(){Id=3,AccountType="current",Balance=11000}
            //};
            //for(int i = 0; i < 2; i++)
            //{
            Account accounts = new Account() { Id = 0, AccountType = "savings", Balance = 1000 };
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