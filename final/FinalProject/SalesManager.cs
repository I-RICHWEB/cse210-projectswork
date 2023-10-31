using System;
using System.IO;


public class SalesManager{
    private List<Products> _productList = new();
    private List<Cart> _cartList = new();
    private List<Customer> _customerList = new();
    private string _productFileName;
    private string _customerListfileName = "customers.txt";
    private int _order = 0;
    private List<string> _userNamesList = new List<string>();
    private bool _signIn;
    private int _currentCustomerIndex;
    private bool _isBonus;
    private bool _isQualify;
    private double _discount;

    public SalesManager(){}

    public void Start(){
        string shopping = "";

        while (shopping != "4"){
            
            Console.Write("\nWELCOME TO IRICH ONLINE STORE\n\nPlease, select from the options" + 
            " below.\n\nOptions:\n  1. Log-In\n  2. Sign-Up\n  3. Go Shopping\n  4. Exit\nEnter your option: ");
            shopping = Console.ReadLine();
            if (_signIn){

                DisplayCustomer(_customerList[_currentCustomerIndex]);
                Console.WriteLine($"Order: [{_order}]");
            }

            if (shopping == "1"){
                LoadCustomer();
                LogIn();

            } else if (shopping == "2") {
                LoadCustomer();
                SignUp();

            }else if (shopping == "3"){
                if (_signIn){

                    DisplayCustomer(_customerList[_currentCustomerIndex]);
                    Console.WriteLine($"\nOrder: [{_order}]");

                    ProductMenu();
                }else {
                    ProductMenu();
                }
            }else {
                if (shopping != "4"){
                    Console.WriteLine("Oop! Invalid option.");
                }
            }
            
        }
        SaveCustomer();
        
    }
    public void DisplayCustomer(Customer customer){
        customer.DisplayInfo();
    }

    public void LogIn(){

        Console.Write("\nPlease enter your username to log in\nEnter your userName: ");
        string userName = Console.ReadLine();
        if (_userNamesList.Contains(userName)){
            for (int i = 0; i < _customerList.Count; i++){
                if (userName == _customerList[i].GetUserName()){
                    _signIn = true;
                    _currentCustomerIndex = i;

                    DisplayCustomer(_customerList[i]);
                    Console.WriteLine($"Order: [{_order}]");

                    ProductMenu();
                    
                }

            }
        }else {
            Console.WriteLine("\nUserName not found, or incorrect.\n\nEnter Sign-Up option if it's your first time, or Enter your correct UserName.");
        }
        
        
    }

    public void SignUp(){
        Console.Write("Enter your full name in this order (first middle last): ");
        string fullName = Console.ReadLine();

        Console.Write("\nEnter your email address: ");
        string email = Console.ReadLine();

        Console.Write("\nEnter your prefer userName: ");
        string userName = Console.ReadLine();

        

        if (_userNamesList.Contains(userName)){
            Console.Write("\nOop! This userName has been picked by someone else.\nEnter a different userName: ");
            userName = Console.ReadLine();
        }else {
            _userNamesList.Add(userName);
            Customer newCustomer = new(fullName, email, userName);
            _customerList.Add(newCustomer);
        }
        Console.WriteLine($"You will be redirected to Log-In");
        LogIn();

    }

    public void ProductMenu(){
        string back = "";

        while (back != "5"){
            Console.Write("\nSelect the kind of product you want to purchase from the list:\n  1. Household " + 
            "Appliances\n  2. Working Tools\n  3. Food-Stuff\n\nSelect other option:\n  4. View Cart\n  5. Go Back\nEnter your option: ");
            back = Console.ReadLine();
            
            if (back == "1"){
                _productFileName = "householdAppliance.txt";
                DisplayProduct();

            }else if (back == "2"){
                _productFileName = "workingTools.txt";
                DisplayProduct();

            }else if (back == "3"){
                _productFileName = "foodstuff.txt";
                DisplayProduct();

            }else if (back == "4"){
                ViewCart();
                if (_cartList.Count > 0){
                    CartMenu();
                }else {
                    Console.Write("Select Option:\n  1. Go back\nEnter option: ");
                    Console.ReadLine();
                }

            }else {
                if (back != "5"){
                    Console.WriteLine("Invalid option!");
                }
            }

        }
        
    }

    public void DisplayProduct(){
        Console.Clear();
        LoadProduct();

        string action = "";
        while (action != "3"){
            Console.WriteLine($"{"Name",-25} Price\n");
            for (int i = 0; i < _productList.Count; i++){
                Console.Write($"{i + 1}. ");
                _productList[i].DisplayProduct();
            }
            Console.Write("\nSelect from the option:\n  1. Add to Cart\n  2. View Cart\n  3. Go Back To Product Menu\nEnter Option: ");
            action = Console.ReadLine();
            if (action == "1"){

                Console.Write("Enter the number of the item: ");
                int proIndex = int.Parse(Console.ReadLine());

                if (proIndex <= _productList.Count){
                    int itemIndex = proIndex - 1;
                    Console.Write("How many do you want?: ");
                    int qty = int.Parse(Console.ReadLine());
                    AddToCart(_productList[itemIndex], qty);
                }else {
                    Console.WriteLine("\nThere is no item with that number!\n");
                }
                
            }else if (action == "2"){
                ViewCart();
                if (_cartList.Count > 0){
                    CartMenu();
                }else {
                    Console.Write("Select Option:\n  1. Go back\nEnter option: ");
                    Console.ReadLine();
                }
                

            }else {
                if (action != "3"){
                    Console.WriteLine("Invalid option!");
                }
            }
        }
        
    }

    public void ViewCart(){
        Console.Clear();
        Console.WriteLine($"   {"Name", -20}{"Price", -20}{"Quantity", -20}{"Final Price",-20}\n");
        for (int i = 0; i < _cartList.Count; i++){
            Console.Write($"{i + 1}. ");
            _cartList[i].DisplayCart();
        }

        if (_signIn){

            bool checkItemBonus = _customerList[_currentCustomerIndex].GetItemBonus();
            
            if(!checkItemBonus && _cartList.Count < 10){
                Console.WriteLine($"\n -----You currently have {_cartList.Count} item(s) in cart for purchase. " + 
                "Purchase up to 10 items upwards to get a gift bonus.-----\n");
            }else if (!checkItemBonus && _cartList.Count >= 10){
                Console.WriteLine("\n***Congratulations! You qualify for a gift bonus at purchase counter.***\n");
                _isBonus = true;
            }else {
                Console.WriteLine("\n-----You have won our gift bonus before.-----\n");
            }

        }else {
            Console.WriteLine("\n-----Sign-in to see available bonuses.-----\n");
        }

        
        
    }
    public void CartMenu(){
        Console.Write("\nSelect an option:\n  1. Check-Out\n  2. Continue Shopping\n  3. Remove Item\nEnter Your Option: ");
        string reply = Console.ReadLine();
        if (reply == "1"){
            CheckOut();
            CheckOutMenu();

        }else if (reply == "3"){
            RemoveItemFromCart();
        }else {
            if (reply != "2"){

                Console.WriteLine("Invalid Option! (Redirected to previous page)");
            }
        }
    }

    public void AddToCart(Products prod, int qty){
        string productInfo = prod.GetProduct();
        string[] parts = productInfo.Split("~");
        string name = parts[0];
        double price = double.Parse(parts[1]);
        Cart cart = new(name, price, qty);
        _cartList.Add(cart);
    }

    public void RemoveItemFromCart(){
        Console.Write("\nSelect item to remove: ");
        int removeIndex = int.Parse(Console.ReadLine()) - 1;
        int check = removeIndex + 1;

        if (check > _cartList.Count){
            Console.WriteLine("\nThere is no such Item!");
        }else
        {
            _cartList.RemoveAt(removeIndex);
            Console.WriteLine("Item is removed from Cart.");
        }
        
    }

    public void IsBonus(){
        
    }

    public void CheckOut(){
        Console.WriteLine($"{"Name", -20} {"Price", -15}  {"Quantity", -15} Final Price\n");
        double subTotal = 0;
        for (int i = 0; i < _cartList.Count; i++){
            Console.Write($"{i + 1}. ");
            _cartList[i].DisplayCart();
            subTotal = subTotal + _cartList[i].GetFinalPrice();
        }

        if (_signIn){

            int checkPurchase = _customerList[_currentCustomerIndex].GetPurchase();
            
            if(checkPurchase < 10){
                Console.WriteLine($"\n -----You have made {_customerList[_currentCustomerIndex].GetPurchase()} purchase(s). " + 
                "make purchase 10 times to get a 5% discount bonus on your tenth purchase.-----\n");
            }else if (checkPurchase == 10){
                Console.WriteLine("\n***Congratulations! You qualify for a  5% discount bonus at purchase counter.***\n");
                _isQualify = true;

            }else {
                Console.WriteLine("\n-----You have won our gift bonus before.-----\n");
            }

        }else {
            Console.WriteLine("-----Sign-in to see available bonuses.-----\n");
        }

        CheckOut newCheckOut = new(subTotal, _discount);
        newCheckOut.DisplayCheckOut();

        

    }

    public void CheckOutMenu(){
        Console.Write("\nSelect from the option:\n  1. Purchase\n  2. Go back Shopping\nEnter Option: ");  
        string response = Console.ReadLine();
        if (response == "1"){
            Purchase();

        }else {
            if (response != "2"){

                Console.WriteLine("Invalid Option! (Redirected to previous page)");
            }
        }

    }

    public void Purchase(){
        Console.Clear();
        
        if (_signIn == true){

            if (_isBonus){
                ItemBonus gift = new(_isBonus);
                string giftItem = gift.GetGift();
                string[] parts = giftItem.Split("~");
                string name = parts[0];
                double price = double.Parse(parts[1]);
                Products giftProd = new(name, price);
                AddToCart(giftProd, 1);
                _isBonus = false;
            }

            if (_isQualify){
                DiscountBonus discount = new(_isBonus, _isQualify);
                _discount = discount.GetDiscount();

                _customerList[_currentCustomerIndex].SetDiscount(discount.GetNumberOfDiscount());
                _isQualify = false;
                _customerList[_currentCustomerIndex].SetPurchase(-10);

            }else {
                _discount = 0;
            }
            
            _customerList[_currentCustomerIndex].SetPurchase(1);
            
            if (_isBonus){
                _customerList[_currentCustomerIndex].SetItemBonus(_isBonus);
            }
            _customerList[_currentCustomerIndex].DisplayInfo();
            string date = DateTime.Now.ToLongDateString();
            Console.WriteLine($"\n------IRICH ONLINE STORE------\nCustomer Reciept.\nDate:");
            Console.WriteLine($"Customer Name: {_customerList[_currentCustomerIndex].GetFullName()}\nEmail Address: {_customerList[_currentCustomerIndex].GetEmail()}\n");

            CheckOut();
            if (_isQualify){
                Console.WriteLine("Congratulations! A 5% discount have been deducted from your subtotal.");
            }

            Console.WriteLine($"\nDelivery directions has been sent to this  email address: {_customerList[_currentCustomerIndex].GetEmail()}\n");
            Console.WriteLine("-----Thanks for your Patronage!-----");

            Thread.Sleep(10000);

            _cartList.Clear();
        }else {
            Console.Write("\nSelect an option\n  1. Log-In\n  2. Sign-Up\nEnter Option: ");
            string answer = Console.ReadLine();
            if (answer == "1"){
                LogIn();
                Purchase();
            }else if (answer == "2"){
                SignUp();
                Purchase();
            }else {
                Purchase();
            }
        }
    }

    public void SaveCustomer(){
        using (StreamWriter sw = new StreamWriter(_customerListfileName)){
            foreach (Customer customer in _customerList){
                string recordCustomer = customer.GetInfo();
                sw.WriteLine(recordCustomer);
            }
            _customerList.Clear();
            _userNamesList.Clear();
        }
        
        
    }

    public void LoadCustomer(){
        _customerList.Clear();
        _userNamesList.Clear();

        if (File.Exists(_customerListfileName)){
            string[] lines = File.ReadAllLines(_customerListfileName);
            foreach (string line in lines){
                string[] parts = line.Split("~");
                string fullName = parts[0];
                string email = parts[1];
                string userName = parts[2];
                bool itemBonus = bool.Parse(parts[3]);
                int discBonus = int.Parse(parts[4]);
                int purchase = int.Parse(parts[5]);
                Customer customer = new(fullName, email, userName, discBonus, purchase, itemBonus);
                _customerList.Add(customer);
                _userNamesList.Add(userName);
           
            }
        }
    }

    public void LoadProduct(){
        _productList.Clear();
        string[] lines = File.ReadAllLines(_productFileName);
        foreach (string line in lines){
            if (line != ""){
                string[] parts = line.Split("~");
                string name = parts[0];
                double price = double.Parse(parts[1]);
                Products product = new(name, price);
                _productList.Add(product);
            }
            
        }
    }
}