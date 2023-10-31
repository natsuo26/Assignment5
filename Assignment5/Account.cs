using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Account
    {
        int id;
        public int Id {  get { return id; } set { id = value; } }
        string? accountType;
        public string? AccountType { get {  return accountType; } set {  accountType = value; } }    
        double balance;
        public double Balance { get { return balance;} set { balance = value; } }   
        public bool Withdraw(double amount)
        {
            if (balance >=amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
        public string GetDetails()
        {
            StringBuilder details = new StringBuilder();
            details.AppendLine("Account Id: " + Convert.ToString(id));
            details.AppendLine("Account Type: " + AccountType);
            details.Append("Balance: " + Convert.ToString(balance));
            return details.ToString();
        }
        
    }
}
