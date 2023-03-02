using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public Rigidbody2D playerRigidbody;
    public float jumpForce = 15;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
    }

    void OnJump()
    {
        playerRigidbody.velocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Menu");
    }

    private void OnBecameInvisible()
    {
        SceneManager.LoadScene("Menu");
    }
}
