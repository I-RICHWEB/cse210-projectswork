using System;


public class FirstTimeCustomer : Customer{


    public FirstTimeCustomer(string fullName, string email, string userName) : base(fullName, email, userName){

    }

    public override void DisplayInfo()
    {
        throw new NotImplementedException();
    }

    public override string GetInfo()
    {
        throw new NotImplementedException();
    }
}