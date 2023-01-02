using BankAccount;
Account acc=new Account(1,100);
acc.Deposit(200);
Console.WriteLine(acc.Balance);
acc.Balance=12345;
Console.WriteLine(acc.Balance);


List<Account>acct=new List<Account>();
acct.Add(acc);
acct.Add(new Account(2,300));


foreach(Account accc in acct){
    Console.WriteLine("account balance {0} account number {0}   ",accc.Balance,accc.Actno);
}



























// using BankAccount;
// using System.Collections.Generic;
// Account account1=new Account(117,100000);
// account1.Deposit(15000);
// float  currentBalance123=account1.GetBalance();
// Account account2=new Account<>(101,90000);
// account2.Deposit(15000);
// float  currentBalance123=account1.GetBalance();

// List<Account>act=new List<>();
// act.Add(account1);
// act.Add(account2);

// foreach(Account acc in act){
//     Console.WriteLine(act);
// }
