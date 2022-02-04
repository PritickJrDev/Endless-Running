using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPScript : MonoBehaviour
{
    public float movingSpeed;
    public GameObject firework;
    public GameObject spawnPoint;

    void Update()
    {
        transform.Translate(Vector2.left * movingSpeed * Time.deltaTime);
        Instantiate(firework, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
}
