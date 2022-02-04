using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSound : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            SoundScript.PlaySound("crate");
        }
    }
}

