using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Character1 : MonoBehaviour {
    public Renderer rend;
    public int pose;

	// Use this for initialization
	void Start () {
        rend = GetComponent<MeshRenderer>();
        pose = 0;
    
	}//fin du Start
	
	// Update is called once per frame
	void Update () {

        //Pèse sur A
		if (Input.GetButtonDown("A")){
            rend.material.SetColor("_Color", Color.green);
            pose = 1;
        }

        //Pèse sur B
        if (Input.GetButtonDown("B"))
        {
            rend.material.SetColor("_Color", Color.red);
            pose = 2;
        }

        //Pèse sur X
        if (Input.GetButtonDown("X"))
        {
            rend.material.SetColor("_Color", Color.blue);
            pose = 3;
        }

        //Pèse sur Y
        if (Input.GetButtonDown("Y"))
        {
            rend.material.SetColor("_Color", Color.yellow);
            pose = 4;
        }

    }//fin de l'Update

}//fin de la classe
