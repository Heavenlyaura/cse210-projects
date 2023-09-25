﻿using System.Dynamic;

namespace Learning03;

public class Fraction
{
    private int _top;
    private int _bottom;

   
/* ------------------------------CONSTRUCTORS--------------------------------------*/
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

/* -------------------------------------------------------------------------------------*/

/* -------------------------GETTERS AND SETTERS-----------------------------------------*/

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
/* ---------------------------------------------------------------------------------------*/


/* -----------------------------------MEMBER FUNCTIONS-------------------------------------*/

    public string GetFractionalString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

   public double GetDecimalValue()
    {
        return _top / (double)_bottom;
    }
}
