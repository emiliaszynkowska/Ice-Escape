using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracking : MonoBehaviour
{

    Transform player;
    float offsetX;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        offsetX = transform.position.x - player.position.x;
    }
    
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(player.position.x + offsetX, 0, float.MaxValue);
        transform.position = pos;
    }

}
