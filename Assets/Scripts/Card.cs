using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Card
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;
    public Sprite spriteImage;

    public Card() { }
    public Card(int Id, string CardName, int Cost, int Power, string CardDescription, Sprite SpriteImage)
    {
        this.id = Id;
        this.cardName = CardName;
        this.cost = Cost;
        this.power = Power;
        this.cardDescription = CardDescription;
        this.spriteImage = SpriteImage;
    }
}
