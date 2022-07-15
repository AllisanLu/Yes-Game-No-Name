using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<Card> hand;
    int health;
    void Start()
    {
        
    }

    public List<Card> GetHand()
    {
        return hand;
    }
    
    public void DrawCards()
    {
        //Dice is rolled in GameManager
    }

    public void Call()
    {

    }

    public void Fold()
    {

    }


    public void AddCard(Card card)
    {
        hand.Add(card);
    }

    public List<Card> RevealHand()
    {
        for (int i = 0; i < hand.Count; i++)
        {
            hand[i].ShowCard();
        }
        return hand;
    }

    public void Clear()
    {
        hand = new List<Card>();
    }

}
