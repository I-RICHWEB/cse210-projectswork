using System;


public class ItemBonus : Bonus{

    private string _itemGift;
    private string _itemBonusFileName = "Gifts";

    public ItemBonus(bool isBonus) : base(isBonus){

    }

    public override bool IsBonus()
    {
        throw new NotImplementedException();
    }

    public string GetGift(){
        return _itemGift;
    }
}