using BankAccount;
using LearnDelegate;

BankManager bm=new BankManager();
BankOperation blockAcc=new BankOperation(bm.BlockAccount);
BankOperation semail=new BankOperation(bm.SendEmail);
BankOperation sms=new BankOperation(bm.SendSMS);

Console.WriteLine("Entered amount should be greater than 5000");
double money=double.Parse(Console.ReadLine());


Account acct=new Account(money);


acct.UnderBalance+=blockAcc;
acct.UnderBalance+=semail;
acct.UnderBalance+=sms;
if(money<5000){
    Console.WriteLine("Amount you are trying to deposit is less than 5000,If you want to use your account your account balance must be 5000");
   acct.BankProcess();
}
else{
    Console.WriteLine("Enter amount to be withdrawned");
double amount= double.Parse(Console.ReadLine());
acct.Withdraw(amount);

acct.BankProcess();

}





