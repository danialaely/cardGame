using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card 
{
    public int cardId;
    public string cardName;
    public int cardPower;
    public Card() { }
    public Card(int id, string name, int power) 
    {
        cardId = id;
        cardName = name;
        cardPower = power;

    }
}
