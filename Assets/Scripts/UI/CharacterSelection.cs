using UnityEngine;
using System.Collections;

public class CharacterSelector : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerSpawnPosition = new Vector3(0, 1, -7);
    public Character[] characters;

    public GameObject characterSelectPanel;

    public void OnCharacterSelect(int characterChoice)
    {
        characterSelectPanel.SetActive(false);
        GameObject spawnedPlayer = Instantiate(player, playerSpawnPosition, Quaternion.identity) as GameObject;
        Character selectedCharacter = characters[characterChoice];
    }
}