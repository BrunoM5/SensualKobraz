using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Wall : MonoBehaviour {
    public float vitesse;
    public int pose;
    public Renderer rend;
    private Color color;
    

	// Use this for initialization
	void Start () {
        gameObject.tag = "wall";
        rend = GetComponent<MeshRenderer>();
        vitesse = 0.25f;
        AssignRandomPose();

        //_________________________________________________POSES
        if (pose == 1){
            rend.material.SetColor("_Color", Color.green);
            color = rend.material.color;
        }
        if (pose == 2){
            rend.material.SetColor("_Color", Color.red);
            color = rend.material.color;
        }
        if (pose == 3){
            rend.material.SetColor("_Color", Color.blue);
            color = rend.material.color;
        }
        if (pose == 4){
            rend.material.SetColor("_Color", Color.yellow);
            color = rend.material.color;
        }
        //_________________________________________________

        
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(vitesse, 0f, 0f, Space.Self);
        if(transform.position.x > 5){
            Destroy(gameObject);

            /* Color tempColor = gameObject.GetComponent<Renderer>().material.color;
             tempColor.a -= (1.0f - rateOfDecay);
             gameObject.GetComponent<Renderer>().material.color = tempColor;*/
        }
    }

    //Mes Fonctions
    void AssignRandomPose(){
        pose = Random.Range(1, 5);
        //Debug.Log(pose);
    }

}
