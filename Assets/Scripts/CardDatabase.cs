using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardsList = new List<Card>();
    public static int amountOfDifferentCards = 0;

    private void Awake()
    {
        InitializeBasicDeck();
    }

    private static void InitializeBasicDeck()
    {
        cardsList.Add(new Card(0, "Air", 1, 0, "Het element van vogels en vlaggen.", Resources.Load<Sprite>("air")));
        cardsList.Add(new Card(1, "Water", 1, 0, "Het element van de zeeën en soep", Resources.Load<Sprite>("WaterSprite")));
        cardsList.Add(new Card(2, "Fire", 1, 0, "Dit is een kaart.", Resources.Load<Sprite>("fire")));
        cardsList.Add(new Card(3, "Earth", 1, 0, "Dit is een kaart.", Resources.Load<Sprite>("earth")));
        amountOfDifferentCards = cardsList.Count;
        Debug.Log("There are " + amountOfDifferentCards + " different cards in the db.");
    }
}
