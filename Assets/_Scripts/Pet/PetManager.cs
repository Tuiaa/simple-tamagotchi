using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetManager : MonoBehaviour
{
    /* GENERAL */
    [SerializeField] private GameObject _pet;
    private PetStatus _petStatus = new PetStatus();

    /*  EVENTS  */
    public delegate void PetHasDiedEventHandler();
    public static event PetHasDiedEventHandler PetHasDied;

    public void AddHungerAndCheckStatus(int amount)
    {

        if (_petStatus.Hunger - amount > 0)
        {
            _petStatus.Hunger = _petStatus.Hunger - amount;
        }
        else
        {
            // later add timer so it doesn't die instantly
            PetHasDied?.Invoke();
        }
    }

    public void ReduceHungerAndCheckStatus(int amount)
    {

        if (_petStatus.Hunger + amount >= _petStatus.MaxHunger)
        {
            _petStatus.Hunger = _petStatus.MaxHunger;
        }
        else
        {
            _petStatus.Hunger = +amount;
        }
    }

    public void AddLoveAndCheckStatus(int amount)
    {
        if (_petStatus.Love + amount >= _petStatus.MaxLove)
        {
            _petStatus.Love = _petStatus.MaxLove;
        }
        else
        {
            _petStatus.Love = +amount;
        }
    }

    public void ReduceLoveAndCheckStatus(int amount)
    {
        if (_petStatus.Love - amount > 0)
        {
            _petStatus.Love = -amount;
        }
        else
        {
            // later add timer so it doesn't die instantly
            PetHasDied?.Invoke();
        }
    }

    public void AddAgeAndCheckStatus(int amount)
    {
        if (_petStatus.Age <= _petStatus.MaxAge)
        {
            _petStatus.Age = +amount;
        }
        else
        {
            PetHasDied?.Invoke();
        }
    }

}
