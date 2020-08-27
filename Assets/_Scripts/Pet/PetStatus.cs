using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetStatus : IPetStatus
{
    /* GENERAL */
    private int _hunger = 100;
    private int _maxHungerAmount = 100;
    private int _love = 100;
    private int _maxLoveAmount = 100;
    private int _age = 0;
    private int _maxAge = 7;
    private bool _isAsleep = false;

    public int Hunger
    {
        get { return _hunger; }
        set { _hunger = value; }
    }

    public int MaxHunger
    {
        get { return _maxHungerAmount; }
    }

    public int Love
    {
        get { return _love; }
        set { _love = value; }
    }

    public int MaxLove
    {
        get { return _maxLoveAmount; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public int MaxAge
    {
        get { return _maxAge; }
    }

    public bool Asleep
    {
        get { return _isAsleep; }
        set { _isAsleep = value; }
    }
}
