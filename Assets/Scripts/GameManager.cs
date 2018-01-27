using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject player1Spawner;
    public GameObject player2Spawner;
    public GameObject character1;
    public GameObject character2;
    public bool countdown = false;
    public float timeLeft = 120.0f;
    public bool gameOver = false;


    // Use this for initialization
    void Start () {
        //countdown = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (countdown){
            timeLeft -= Time.deltaTime;
            Debug.Log(timeLeft);
            if(timeLeft <= 0){
                gameOver = true;
            }
        }
		//if both players are ready
	}

    // Fonctions

    void StartGame(){
       // Instantiate(character1,)
    }

    void TimerStart(){
        countdown = true;
    }

}
