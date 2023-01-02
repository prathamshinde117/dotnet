namespace BankAccount;
public class Account{
    private int actno;
    private float balance;

    public Account(int actno,float balance){
        this.actno=actno;
        this.balance=balance;
    }

    public int Actno{
        get{return this.actno;}
        set{this.actno=value;}
    }
    public float Balance{
        get{return this.balance;}
        set{this.balance=value;}
    }

    public void Deposit(int amount){
        balance+=amount;
    }
    public void Withdraw(int amount){
        if(balance==0){
            throw new Exception("you have not enough balance!!!");
        
        }
        balance+=amount;
    }
}