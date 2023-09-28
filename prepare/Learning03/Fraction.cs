using System;
using System.Reflection.Metadata.Ecma335;

public class Fraction {
    private int _topNumber;
    private int _bottomNumber;

    public Fraction(){
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int wholeNumber){
        _topNumber = wholeNumber;
        _bottomNumber = 1;

    }

    public Fraction(int topNumb, int bottomNumb){
        _topNumber = topNumb;
        _bottomNumber = bottomNumb;
    }


    public int GetTopNum(){
        return _topNumber;
    }

    public void SetTopNum(int givingNumber){
        _topNumber = givingNumber;
    }


    public int GetbottomNum(){
        return _bottomNumber;
    }

    public void SetbottomNum(int numerator){
        _bottomNumber = numerator;
    }

    public string GetFractionString(){
        string fraction = _topNumber + "/" + _bottomNumber;
        return fraction;
    }

    public double GetDecimalValue(){
        return (double)_topNumber / (double)_bottomNumber;
    }

}