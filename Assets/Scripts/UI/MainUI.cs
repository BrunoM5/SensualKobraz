using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour {

    public Text scorePlayer1Text;
    public Text scorePlayer2Text;
    public Scores scores;
    // Use this for initialization
    void Start () {

        scorePlayer1Text.text = scores.scorePlayer1.ToString();
        scorePlayer2Text.text = scores.scorePlayer2.ToString();
    }

   
    // Update is called once per frame
    void UpdateScore () {
        scorePlayer1Text.text = scores.scorePlayer1.ToString();
        scorePlayer2Text.text = scores.scorePlayer2.ToString();
    }
}
