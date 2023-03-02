using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    public int moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }


}
