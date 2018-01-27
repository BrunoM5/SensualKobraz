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
	}

   
    // Update is called once per frame
    void Update () {
        scorePlayer1Text.text = scores.scorePlayer1.ToString();
    }
}
