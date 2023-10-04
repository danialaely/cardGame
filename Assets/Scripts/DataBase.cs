using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    public List<Card> cardlist = new List<Card>();
   
    // Start is called before the first frame update
    private void Awake()
    {
        cardlist.Add(new Card(0,"danial",5));
        cardlist.Add(new Card(1, "john", 6));
    }
}
