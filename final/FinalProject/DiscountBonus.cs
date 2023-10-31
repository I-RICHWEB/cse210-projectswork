using System;


public class DiscountBonus : Bonus{
    
    private double _discountBonus;
    private bool _isDiscount;
    private int _disct = 0;

    public DiscountBonus(bool isBonus, bool isDiscount) : base(isBonus){
        _isDiscount = isDiscount;
        if (_isDiscount){
            _discountBonus = 0.05;
            _disct += 1;

        }
    }

    public double GetDiscount(){

        return _discountBonus;
    }
    public int GetNumberOfDiscount(){
        return _disct;
    }

}