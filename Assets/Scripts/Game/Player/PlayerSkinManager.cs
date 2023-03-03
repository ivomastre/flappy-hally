using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerSkinManager : MonoBehaviour
{
    public GameObject player;



    void Start()
    {
        string skin = PlayerPrefs.GetString("PlayerSkin");

        // Load player skin from PlayerSkin Prefab
        GameObject playerSkin = Resources.Load<GameObject>($"Prefabs/PlayerSkins/{skin}");

        // Set player skin as player sprite
        player.GetComponent<SpriteRenderer>().sprite = playerSkin.GetComponent<SpriteRenderer>().sprite;
        // Set player scale
        player.transform.localScale = playerSkin.transform.localScale;

        Debug.Log(player.GetComponent<SpriteRenderer>().sprite.bounds.size);

    }
}
