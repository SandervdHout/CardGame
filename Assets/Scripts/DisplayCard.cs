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
        this.id = displayCard[0].id;
        this.cardName = displayCard[0].cardName;
        this.cost = displayCard[0].cost;
        this.cardDescription = displayCard[0].cardDescription;
        this.imageSprite = displayCard[0].spriteImage;

       nameText.text= displayCard[0].cardName;
       costText.text= displayCard[0].cost.ToString();
       descriptionText.text = displayCard[0].cardDescription;
        artImage.sprite = displayCard[0].spriteImage;
      
    }
}
