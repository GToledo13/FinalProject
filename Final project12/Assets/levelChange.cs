using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class levelChange : MonoBehaviour
{
    public int sceneBuildIndex;


    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Triggered Entered");

        if(other.tag == "PLAYER")
        {
            print("switching scene to" + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }

    }

}
