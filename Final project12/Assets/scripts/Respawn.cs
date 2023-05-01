using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnPoint;
    // Update is called once per frame
   private void Start()
    {
        StartCoroutine(RespawnObstacle());
    }


    IEnumerator RespawnObstacle()
    {
        while (true)
        {
            float waitTime = Random.Range(1f, 2f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);
        }
    }


}
