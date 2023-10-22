using System;

public abstract class Customer{
    private string _fullName;
    private string _email;
    private string _userName;

    public Customer(string fullName, string email, string userName){
        _fullName = fullName;
        _email = email;
        _userName = userName;
    }

    public abstract void DisplayInfo();

    public abstract string GetInfo();


}