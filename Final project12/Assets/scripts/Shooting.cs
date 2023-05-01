using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform shootLoc;
    public GameObject projectilePrefab;
    public float speed = 35.0f;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, shootLoc.position, projectilePrefab.transform.rotation);

            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
