using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectionP1 : MonoBehaviour {

    private GameObject[] characterList;
    private int index;

	// Use this for initialization
	void Start () {
        characterList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++){
            characterList[i] = transform.GetChild(i).gameObject;
        }
        foreach(GameObject go in characterList){
            go.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Fonctions
    private void ToggleLeft()
    {
        characterList[index].SetActive(false);

        index--;
        if(index < 0)
        {
            index = characterList.Length - 1;
        }
        characterList[index].SetActive(true);
    }

    private void ToggleRight()
    {
        characterList[index].SetActive(false);
        index++;
        if (index == characterList.Length)
        {
            index = 0;
        }
        characterList[index].SetActive(true);
    }



}
