using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScoreTrigger : MonoBehaviour
{
    public ScoreLogic scoreLogic;

    // Start is called before the first frame update
    void Start()
    {
        scoreLogic = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreLogic>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            scoreLogic.increaseScore();
        }
    }
}
