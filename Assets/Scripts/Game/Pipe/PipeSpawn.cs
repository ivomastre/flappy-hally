using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public float spawnRate = 0.77f;
    private float spawnInterval = 0;
    public GameObject pipePrefab;
    public int heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipePrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnInterval < spawnRate)
        {
            spawnInterval = spawnInterval + Time.deltaTime;

            return;
        }

        SpawnPipe();
        spawnInterval = 0;
    }

    void SpawnPipe()
    {
        float lowestHeight = transform.position.y - heightOffset;
        float highestHeight = transform.position.y + heightOffset;

        float randomHeight = Random.Range(lowestHeight, highestHeight);

        Instantiate(pipePrefab, new Vector3(transform.position.x, randomHeight, 0), transform.rotation);
    }
}
