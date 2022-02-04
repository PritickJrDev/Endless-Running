using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidItems : MonoBehaviour
{
    public int MakeDamage;
    public float moveSpeed;
    public GameObject stoneEffect;
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            Instantiate(stoneEffect, transform.position, Quaternion.identity);
            FindObjectOfType<Player>().health -= MakeDamage;
          //  Debug.Log("Health : " + FindObjectOfType<Player>().health);
            Destroy(gameObject);
        }
    }

}
