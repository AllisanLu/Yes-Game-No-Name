using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    Deck deck1;
    Deck deck2;
    Deck deck3;

    Player player1;
    Player player2;
    Player currentPlayer;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        deck1 = new Deck();
        deck1.Shuffle();

        deck2 = new Deck();
        deck2.Shuffle();

        deck3 = new Deck();
        deck3.Shuffle();

        currentPlayer = player1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int RollDice()
    {
        int dice1 = Random.Range(1, 6);
        int dice2 = Random.Range(1, 6);

        return dice1 + dice2;
    }

    public bool GameOver()
    {
        return false;
    }

    public void NewRound()
    {
        deck1 = new Deck();
        deck1.Shuffle();

        deck2 = new Deck();
        deck2.Shuffle();

        deck3 = new Deck();
        deck3.Shuffle();

        //change this to switch which player starts first
        currentPlayer = player1;
    }
}
