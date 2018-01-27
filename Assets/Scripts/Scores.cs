using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour {

    public int scorePlayer1;
    public int scorePlayer2;
    public int bonus;

    // Use this for initialization
    void Start ()
    {
        scorePlayer1 = 0;
        scorePlayer2 = 5;
        bonus = 0;
    }

    void ScoreUpPlayer1()
    {
        scorePlayer1 += 10 + bonus;
    }

    void ScoreUpPlayer2()
    {
        scorePlayer2 += 10 + bonus;
    }

    void BonusIncrement()
    {
        bonus += 10;
    }

    void BonusReset()
    {
        bonus = 0;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
