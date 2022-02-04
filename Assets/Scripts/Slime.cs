using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    private Rigidbody2D rb;
    public float slimJumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            rb.AddForce(new Vector2(0f, slimJumpForce), ForceMode2D.Impulse);
            SoundScript.PlaySound("slimeEffect");
        }
        if(col.gameObject.CompareTag("Player"))
        {
            SoundScript.PlaySound("slime");
        }
    }
}
