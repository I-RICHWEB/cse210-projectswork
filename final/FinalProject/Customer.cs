using System;

public class Customer{
    private string _fullName;
    private string _email;
    private string _userName;

    
    private bool _itemBonus;
    private int _discountBonus;
    private int _purchase;

    public Customer(string fullName, string email, string userName, int discBonus = 0, int purchase = 0, bool itemBonus = false){
        _fullName = fullName;
        _email = email;
        _userName = userName;
        _purchase = purchase;
        _itemBonus = itemBonus;
        _discountBonus = discBonus;
    }

    public string GetUserName(){
        return _userName;
    }

    public string GetEmail(){
        return _email;
    }
    public bool GetItemBonus(){
        return _itemBonus;
    }

    public int GetDiscount(){
        return _discountBonus;
    }

    public string GetFullName(){
        return _fullName;
    }
    public void SetPurchase(int purchase){
        _purchase += purchase;
    }
    public int GetPurchase(){
        return _purchase;
    }

    public void SetDiscount(int disc){
        _discountBonus += disc;
    }

    public void SetItemBonus(bool bonus){
        _itemBonus = bonus;
    }

    public void DisplayInfo()
    {
        Console.Clear();
        Console.WriteLine($"Welcome {_userName}\n");
        if (_itemBonus == true){
            Console.WriteLine($"Bonus Gift: Yes.    |   Discount Bonus: [ {_discountBonus} ]   |   Your Purchase(s): [ {_purchase} ]\n");
        }else {
            Console.WriteLine($"Bonus Gift: Not yet.    |   Discount Bonus: [ {_discountBonus} ]   |   Your Purchase(s): [ {_purchase} ]\n");
        }
    }

    public string GetInfo()
    {
        return $"{_fullName}~{_email}~{_userName}~{_itemBonus}~{_discountBonus}~{_purchase}";
    }


}