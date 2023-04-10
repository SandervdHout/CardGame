using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHand : MonoBehaviour  
{
    private List<Card> cardsInHand;
    private GameObject[] currentHand;
    public GameObject card_een;
    public GameObject card_two;
    public GameObject card_three;
    private int amountOfCardsInHand = 0;

    DisplayCard oneCard;
    public bool fullHand = false;


    public void Start()
    {
        cardsInHand = new List<Card>();
        currentHand = GameObject.FindGameObjectsWithTag("ActiveCard");
        DeactivateCurrentHand();
    }
    public void AddCard(Card card)
    {
        if (amountOfCardsInHand == 3)
        {
            fullHand = true;
        }
        else
        {
            cardsInHand.Add(card);
            ActivateCard(card);
            Debug.Log("Added card with name: " + card.cardName);
        }
    }

    private void ActivateCard(Card card)
    {
        Debug.Log("Current hand size is: " + cardsInHand.Count);
        if(currentHand != null)
        {
            int count = 0;
            foreach(GameObject c in currentHand)
            {
                Debug.Log("currenthandloop: " + c.name);
                if(count == cardsInHand.Count-1)
                {
                    Debug.Log("correct!");
                    c.SetActive(true);
                    oneCard = c.GetComponent<DisplayCard>();
                    oneCard.SetCard(card);
                }
                count++;
            }
            amountOfCardsInHand++;
        }
       
    }

    private void DeactivateCurrentHand()
    {
        foreach (GameObject c in currentHand)
        {
            c.SetActive(false);
        }
    }

}
