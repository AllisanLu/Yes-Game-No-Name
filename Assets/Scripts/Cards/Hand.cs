using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    private List<Card> hand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCard(Card card)
    {

    }

    public List<Card> RevealHand()
    {
        return hand;
    }

    public void Clear()
    {
        hand = new List<Card>();
    }
}
