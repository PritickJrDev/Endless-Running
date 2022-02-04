using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] stone;

    private float spawnTime;
    public float startTime;
    public float decreaseTime;
    public float minTime = 0.65f;

    void Update()
    {
        if(spawnTime <= 0)
        {
            int rand = Random.Range(0, stone.Length);
            Instantiate(stone[rand], transform.position, Quaternion.identity);
            spawnTime = startTime;
            if (startTime > minTime)
            {
                startTime -= decreaseTime;
            }
        }
        else
        {
            spawnTime -= Time.deltaTime;
        }
    }
}
