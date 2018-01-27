using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Character2 : MonoBehaviour
{
    public Renderer rend;
    public int pose;
    public float poseReset = 0.75f;
    public bool canPose = true;

    public GameObject gameManager;
    public Scores scoreManager;
    public GameManager scr_gameManager;

    // Triggers

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wall" && pose == other.GetComponent<Scr_Wall>().pose)
        {
            scoreManager.ScoreUpPlayer2();
            scoreManager.bonus += 10;
            Debug.Log("PRO");
            Debug.Log(scoreManager.scorePlayer2);
        }
        else
        {
            scoreManager.BonusReset();
            Debug.Log("noob");
        }
    }
    /*void OnTriggerExit(Collider other)
    {
        if (other.tag == "wall")
        {
        }
    }*/


    // Start
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        pose = 0;
        scoreManager = gameManager.GetComponent<Scores>();
        scr_gameManager = gameManager.GetComponent<GameManager>();

       // scr_gameManager.character2 = this.gameObject.GetComponent<Scr_Character2>();

    }//fin du Start

    // Update is called once per frame
    void Update()
    {

        //if(isTriggered)

        //Pèse sur A
        if (canPose && Input.GetButtonDown("A2"))
        {
            canPose = false;
            //Cue l'animation 1
            rend.material.SetColor("_Color", Color.green);
            pose = 1;
            Invoke("ResetPose", poseReset);
        }

        //Pèse sur B
        if (canPose && Input.GetButtonDown("B2"))
        {
            canPose = false;
            rend.material.SetColor("_Color", Color.red);
            pose = 2;
            Invoke("ResetPose", poseReset);
        }

        //Pèse sur X
        if (canPose && Input.GetButtonDown("X2"))
        {
            canPose = false;
            rend.material.SetColor("_Color", Color.blue);
            pose = 3;
            Invoke("ResetPose", poseReset);
        }

        //Pèse sur Y
        if (canPose && Input.GetButtonDown("Y2"))
        {
            canPose = false;
            rend.material.SetColor("_Color", Color.yellow);
            pose = 4;
            Invoke("ResetPose", poseReset);
        }

    }//fin de l'Update

    //Mes Fonctions

    void ResetPose()
    {
        rend.material.SetColor("_Color", Color.white);
        pose = 0;
        canPose = true;
    }

}//fin de la classe