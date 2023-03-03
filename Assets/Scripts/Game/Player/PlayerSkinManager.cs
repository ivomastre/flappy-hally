using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerSkinManager : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        // Load player skin from PlayerSkin Prefab
        GameObject playerSkin = Resources.Load("Prefabs/PlayerSkinPrefab") as GameObject;
        if (playerSkin == null)
        {
            Debug.LogError("PlayerSkinPrefab not found");
            return;
        }

        // Set player skin as player sprite
        player.GetComponent<SpriteRenderer>().sprite = playerSkin.GetComponent<SpriteRenderer>().sprite;
    }
}
