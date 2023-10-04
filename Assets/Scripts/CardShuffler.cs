using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardShuffler : MonoBehaviour
{
    public DisplayCard displayCard; // Reference to the DisplayCard script
    public GameObject shuffleButton; // Reference to the shuffle button GameObject

    public void ShuffleCard()
    {
        // Generate a random number (0 or 1)
        int randomId = Random.Range(0, 2);

        // Set the random ID in the DisplayCard script
        displayCard.displayid = randomId;
    }

    private void Start()
    {
        Button button = shuffleButton.GetComponent<Button>();
        button.onClick.AddListener(ShuffleCard);
    }
}
