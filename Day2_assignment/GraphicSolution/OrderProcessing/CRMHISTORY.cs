namespace OrderProcessing;
public class CRMHISTORY:ICustomerDetails,IOrderDetails
{
    public void ShowOrderDetails(){
        Console.WriteLine("Order is delivered..");
    }
    public void CustomerDetails(){
        Console.WriteLine("Customer details uploaded");
    }
    public void ChangeProfile(){
        Console.WriteLine("profile is generated!!");
    }
    void ICustomerDetails.ShowDetails(){

    }
    void IOrderDetails.ShowDetails(){

    }
}
