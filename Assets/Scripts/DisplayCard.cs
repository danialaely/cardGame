using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCard : MonoBehaviour
{
    public List<Card> display = new List<Card>();
    public int displayid;

    public TMP_Text nameText;
    public TMP_Text powerText;

    void Start()
    {
        UpdateCardInformation();
    }

    // Update the card information based on displayid
    public void UpdateCardInformation()
    {
        // Find the card with the specified displayid in the list
        Card card = display.Find(c => c.cardId == displayid);

        if (card != null)
        {
            // Display the card's information
            nameText.text = card.cardName;
            powerText.text = card.cardPower.ToString();
        }
        else
        {
            nameText.text = "Card not found";
            powerText.text = "";
        }
    }
}
