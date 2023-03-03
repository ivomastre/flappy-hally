using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Start Game");
        SceneManager.LoadScene("GameScene"); // Game Scene

        // Check if player skin is set, if not, set it to default
        if (PlayerPrefs.GetString("PlayerSkin") == "")
        {
            PlayerPrefs.SetString("PlayerSkin", "Default");
        }
    }
}
