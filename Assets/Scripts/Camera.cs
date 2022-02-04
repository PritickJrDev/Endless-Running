using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform player;
    private Vector3 tempPos;

   // [SerializeField] private float minY, maxY;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void LateUpdate()
    {
        if(player == null)
        {
            return;
        }

        tempPos = transform.position;
        tempPos.y = player.position.y;
        transform.position = tempPos;
    }
}
