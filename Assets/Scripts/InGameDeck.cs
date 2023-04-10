using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class InGameDeck : MonoBehaviour
{
    private GameObject[] currentHand;
    public List<Card> shuffleContainerDeck;
    public PlayerDeck playerDeck;

    private List<Card> cardsInHand;
    private int startingAmountOfCards = 2;

    public PlayerHand playerHand;
    public void Start()
    {
        ShuffleCardsAtStart();
        cardsInHand = new List<Card>();

        //Voeg kaarten toe, tot hoeveel de start hand is
        //DrawCard(startingAmountOfCards);

    }

    public void ShuffleCardsAtStart()
    {
        Debug.Log("start shuffling");
        shuffleContainerDeck = new List<Card>();

        for (int i = 0; i < playerDeck.deck.Count; i++)
        {
            Card temp = playerDeck.deck[i];
            int randomIndex = Random.Range(i, playerDeck.deck.Count);
            playerDeck.deck[i] = playerDeck.deck[randomIndex];
            playerDeck.deck[randomIndex] = temp;
        }

    }

    public void DrawCard(int amountToDraw)
    {
        Debug.Log("start drawing");

        int count = 0;
        if (playerDeck.deck.Count > 0)
        {
            if(!playerHand.fullHand)
            {
                foreach (Card card in playerDeck.deck)
                {
                    count++;
                    if (count == amountToDraw)
                    {
                        playerHand.AddCard(card);
                        playerDeck.deck.Remove(card);
                        break;
                    }
                }
            } 
        }
        else
        {
            Debug.Log("No more cards to draw...");
        }
    }
}






    
