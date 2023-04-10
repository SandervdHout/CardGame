using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardsList = new List<Card>();

    private void Awake()
    {
        cardsList.Add(new Card(0, "Air", 1,0, "Het element van vogels en vlaggen.", Resources.Load<Sprite>("WaterSprite") as Sprite));
        cardsList.Add(new Card(1, "Water", 1, 0, "Het element van de zeeën en soep",Resources.Load<Sprite>("WaterSprite")));
        cardsList.Add(new Card(2, "Fire", 1, 0, "Dit is een kaart.", Resources.Load<Sprite>("WaterSprite")));
        cardsList.Add(new Card(3, "Earth", 1, 0, "Dit is een kaart.", Resources.Load<Sprite>("pp") ));
    }
}
