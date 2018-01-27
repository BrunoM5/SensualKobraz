using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_WallSpawner : MonoBehaviour {
    public bool canSpawn;
    public float cooldown;
    public GameObject monWall;
    public GameObject monCharacter;

	// Use this for initialization
	void Start () {
        canSpawn = true;
        //cooldown = 1.5f;
	}
	
	// Update is called once per frame
	void Update () {
        if (canSpawn){
            SpawnWall();
        }
	}

    //Fonctions
    void SpawnWall(){
        canSpawn = false;
        Instantiate(monWall, transform.position, this.transform.rotation);
        Invoke("ResetSpawner", cooldown);
    }
    void ResetSpawner(){
        canSpawn = true;
    }

}
