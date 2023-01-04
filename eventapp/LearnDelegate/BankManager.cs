namespace LearnDelegate;
public delegate void BankOperation(double amount);

public class BankManager
{


    public void BlockAccount(double amount)
    {
        Console.WriteLine("Account has been blocked");
    }
    public void SendEmail(double amount)
    {
        Console.WriteLine("Email has been sent");
    }
    public void SendSMS(double amount)
    {
        Console.WriteLine("SMS has been sent");
    }


}