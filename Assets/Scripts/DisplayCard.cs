using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public string cardDescription;
    public Sprite imageSprite;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI descriptionText;
    public Image artImage;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CardDatabase.cardsList[displayId].id + " is id of current card");
        displayCard.Add(CardDatabase.cardsList[displayId]);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SetCard (Card card)
    {
        this.id = card.id;
        this.cardName = card.cardName;
        this.cost = card.cost;
        this.cardDescription = card.cardDescription;
        this.imageSprite = card.spriteImage;

        nameText.text = card.cardName;
        costText.text = card.cost.ToString();
        descriptionText.text = card.cardDescription;
        artImage.sprite = card.spriteImage;

    }
}
