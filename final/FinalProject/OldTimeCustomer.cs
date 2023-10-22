using System;


public class OldTimeCustomer : Customer{

    private bool _itemBonus;
    private int _discountBonus;
    private int _purchase;


    public OldTimeCustomer(string fullName, string email, string userName, int purchase, bool itemBonus = false, int discBonus = 0) : base(fullName, email, userName){
        _purchase = purchase;
        _itemBonus = itemBonus;
        _discountBonus = discBonus;
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