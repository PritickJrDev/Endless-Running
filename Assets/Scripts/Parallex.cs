using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallex : MonoBehaviour
{
    public float scrollSpeed;
    public float startX;
    public float endX;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
        if(transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;

        }
    }
}
