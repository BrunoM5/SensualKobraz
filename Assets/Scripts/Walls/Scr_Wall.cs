using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Wall : MonoBehaviour {
    public float vitesse;

	// Use this for initialization
	void Start () {
        vitesse = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(vitesse, 0f, 0f, Space.Self);
    }
}
