using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class BackgroundRepeat : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (!collider.CompareTag("ScoreCollider"))
        {
            Vector3 pos = collider.transform.position;
            pos.x += 82;

            if (collider.tag == "Top Icicle")
            {
                pos.y = new Random().Next(5, 10);
            }
            else if (collider.tag == "Bottom Icicle")
            {
                pos.y = new Random().Next(-8, -3);
            }

            collider.transform.position = pos;
        }
    }
    
}
