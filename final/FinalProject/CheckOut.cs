using System;

public class CheckOut {
    private double _subTotal;
    private double _salesTax;
    private double _total;
    private double _isDiscount;
    
    public CheckOut(double subTotal, double isDisc ){
        
        _isDiscount = isDisc;

        if (_isDiscount > 0){
            double disc = subTotal * _isDiscount;
            _subTotal = subTotal - disc;

        }else {
            _subTotal = subTotal;
        }

        _salesTax = _subTotal * 0.03;
        _total = _subTotal + _salesTax;
        
    }

    public void DisplayCheckOut(){
        Console.WriteLine($"\nSubTotal:     $ {_subTotal:0.00}\nSales Tax:  $ {_salesTax:0.00}\nTotal:  $ {_total:0.00}");
    }

}