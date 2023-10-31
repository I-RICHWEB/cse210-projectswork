using System;


public class ItemBonus : Bonus{

    private string _itemGift;
    private List<string> _gifts = new();
    private string _itemBonusFileName = "Gifts.txt";

    public ItemBonus(bool isBonus) : base(isBonus){
        string[] lines = File.ReadAllLines(_itemBonusFileName);
        foreach (string line in lines){
            if (line != ""){

                _gifts.Add(line);
            }
            
        }
    }

    private void RandomGift(){
        Random r = new();
        int randomIndex = r.Next(_gifts.Count);
        _itemGift = _gifts[randomIndex];
    }

    public string GetGift(){
        RandomGift();
        return _itemGift;
    }
}