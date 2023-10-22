using System;


public class SalesManager{
    private List<Products> _productList = new();
    private List<Cart> _cartList = new();
    private List<Customer> _customerList = new();
    private string _productFileName;
    private string _customerListfileName;
    private int _patronage;

    public SalesManager(){}

    public void Start(){
        string shopping = "";

        while (shopping != "3"){
            Console.Write("WELCOME TO IRICH ONLINE STORE\n\nPlease, select from the options" + 
            " below.\n\nOptions:\n  1. Log-In\n  2. Sign-Up\n  3. Exit\nEnter your option: ");
            shopping = Console.ReadLine();
            
        }
        
    }

    public void LogIn(){

    }

    public void SignUp(){
        
    }

    public void DisplayProduct(){
        
    }

    public void DisplayBonus(){
        
    }

    public void AddToCart(){
        
    }

    public void IsBonus(){
        
    }

    public void CheckOut(){
        
    }

    public void Purchase(){
        
    }

    public void SaveCustomer(){
        
    }

    public void SavePurchase(){
        
    }

    public void LoadCustomer(){
        
    }

    public void LoadProduct(){
        
    }

    public void LoadBonus(){
        
    }

    public void LoadPurchase(){
        
    }

}