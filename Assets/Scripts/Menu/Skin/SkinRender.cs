using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinRender : MonoBehaviour
{
    void OnSkinClick(GameObject skin)
    {
        string skinName = skin.name;

        // Save the skin name to PlayerPrefs
        PlayerPrefs.SetString("PlayerSkin", skinName);
    }

    void Start()
    {
        // Search for all prefabs in Resources/Prefabs/Skins folder
        GameObject[] skins = Resources.LoadAll<GameObject>("Prefabs/PlayerSkins");


        // Add each skin as a child of this object
        foreach (GameObject skin in skins)
        {
            // Create a empty game object with a image component and set the sprite to the skin

            GameObject skinObject = new GameObject();
            skinObject.AddComponent<Image>();
            skinObject.GetComponent<Image>().sprite = skin.GetComponent<SpriteRenderer>().sprite;

            // Set the parent of the skin to this object
            skinObject.transform.SetParent(transform);

            // Set the scale of the skin to 1
            skinObject.transform.localScale = new Vector3(1, 1, 1);

            // Create a button component and add a listener to it
            skinObject.AddComponent<Button>();
            skinObject.GetComponent<Button>().onClick.AddListener(() => OnSkinClick(skin));
        }
    }
}
