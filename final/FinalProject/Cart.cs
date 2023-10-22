using System;

public class Cart{
    private string _itemName;
    private double _itemPrice;
    private int _quantity;
    private double _total;
    private double _salesTax;

    public Cart(string name, double price, int quantity){
        _itemName = name;
        _itemPrice = price;
        _quantity = quantity;
        _total = 0;
        _salesTax = 0.05;
    }

    public void DisplayCart(){

    }

    public string GetCart(){
        return "";
    }
}