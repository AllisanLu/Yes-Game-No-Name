using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck: MonoBehaviour
{
    int level;
    List<Card> cards;

    string[] suits = new string[] { "red", "green", "purple", "blue" };
    string[] types = new string[] { "attack", "heal", "shield", "bomb" };

    public Deck()
    {
        //make 3 cards that are alike for the entire deck
        for (int i = 0; i < suits.Length; i++)
        {
            for (int j = 0; j < types.Length; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Card card = new Card(suits[i], level, types[j]);
                    cards.Add(card);
                }
            }
        }
        Shuffle();
    }

    public void Shuffle()
    {

    }
    
    public Card DrawCard()
    {
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}
