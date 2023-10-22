using System;
using System.Security.Cryptography.X509Certificates;


public abstract class Bonus{
    
    private bool _isBonus;

    public Bonus(bool isBonus){
        _isBonus = isBonus;
    }

    public abstract bool IsBonus();
}