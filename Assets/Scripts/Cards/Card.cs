using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    string suit;
    int level;
    string type;
    // Start is called before the first frame update
    public Card(string suit, int level, string type)
    {
        this.suit = suit;
        this.level = level;
        this.type = type;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
