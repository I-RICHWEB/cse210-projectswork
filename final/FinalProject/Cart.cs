using System;

public class Cart{
    private string _itemName;
    private double _itemPrice;
    private int _quantity;
    private double _finalPrice;
    
    

    public Cart(string name, double price, int quantity){
        _itemName = name;
        _itemPrice = price;
        _quantity = quantity;
        _finalPrice = _itemPrice * _quantity;
    }

    public void DisplayCart(){
        Console.WriteLine($"{_itemName, -20}{_itemPrice, -15}{_quantity, -15}{_finalPrice:0.00}");
    }

    public double GetFinalPrice(){
        return _finalPrice;
    }
}