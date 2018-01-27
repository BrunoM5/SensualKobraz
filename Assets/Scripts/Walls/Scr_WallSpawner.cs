using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_WallSpawner : MonoBehaviour {
    public bool canSpawn;
    public float cooldown;
    public Scr_Wall monWall;

	// Use this for initialization
	void Start () {
        canSpawn = true;
        cooldown = 3.0f;
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
        Instantiate(monWall, this.transform.position, this.transform.rotation);
        Invoke("ResetSpawner", cooldown);
    }
    void ResetSpawner(){
        canSpawn = true;
    }

}
