using System;


public class DiscountBonus : Bonus{
    
    private double _discountBonus;

    public DiscountBonus(bool isBonus) : base(isBonus){

    }

    public override bool IsBonus()
    {
        throw new NotImplementedException();
    }

    public double GetDiscount(){
        return _discountBonus;
    }

}