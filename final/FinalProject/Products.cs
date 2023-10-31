using System;


public class Products{
    private string _name;
    private double _price;

    public Products(string name, double price){
        _name = name;
        _price = price;
    }

    public void DisplayProduct(){
        Console.WriteLine($"   {_name,-25}  $ {_price}");
    }

    public string GetProduct(){
        return $"{_name}~{_price}";
    }
    
}