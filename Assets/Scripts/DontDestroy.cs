using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{



    //first attempt at the solution to preserve player
    
    private void Awake()
    {
        
        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");

        if (player.Length > 1)
        {
            Destroy(player[1]);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
