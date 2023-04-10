using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck;


    // Start is called before the first frame update
    void Start()
    {
        deck = new List<Card>();
        InitializeDeck();
    }

    private void InitializeDeck()
    {
        foreach(Card card in CardDatabase.cardsList)
        {
            deck.Add(card);
        }
    }
 
}
