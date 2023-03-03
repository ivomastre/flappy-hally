using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public Rigidbody2D playerRigidbody;
    public float jumpForce = 7;
    void OnJump()
    {
        playerRigidbody.velocity = Vector2.up * jumpForce;
    }

    void GameOver()
    {
        SceneManager.LoadScene("MenuScene");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }

    private void OnBecameInvisible()
    {
        GameOver();
    }
}
