using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    string suit;
    int level;
    string type;

    private bool shown;
    // Start is called before the first frame update
    public Card(string suit, int level, string type)
    {
        this.suit = suit;
        this.level = level;
        this.type = type;
        shown = false;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCard()
    {
        shown = true;
    }

    public void FlipCard()
    {
        shown = !shown;
    }
    public bool IsShown()
    {
        return shown;
    }
}
