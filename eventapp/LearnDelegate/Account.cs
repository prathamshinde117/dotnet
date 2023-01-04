namespace BankAccount;
using LearnDelegate;
public class Account
{

    public double Balance { get; set; }
    public event BankOperation UnderBalance;

    public Account(double amount)
    {
        this.Balance = amount;

    }

    public void Deposit(double amount)
    {
        this.Balance += amount;

    }
    public void Withdraw(double amount)
    {
        if (this.Balance < 5000)
        {
            Console.WriteLine("Balance is less than 5000, you cant withdraw");
        }
        else
        {
            this.Balance -= amount;
            Console.WriteLine("current Balance: " + this.Balance);
        }



    }

    public override string ToString()
    {
        return "Balance: " + Balance;
    }

    public void BankProcess()
    {
        if (this.Balance < 5000)
        {
            UnderBalance(this.Balance);
        }
    }


}