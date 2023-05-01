using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleLeft : MonoBehaviour
{
    public float moveSpeed;

    
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);
    }
}
