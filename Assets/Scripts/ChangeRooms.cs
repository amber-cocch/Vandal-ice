using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeRooms : MonoBehaviour
{
    // Start is called before the first frame update

    public int sceneIndex;
    // public GameObject protag;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneIndex);

            other.transform.position = GameObject.Find("Spawn").transform.position;
            //Debug.Log(other.transform.position);
            

            //name = sceneName.name;
            //scene = SceneManager.GetActiveScene();
            // protag = this.gameObject;
            //SceneManager.MoveGameObjectToScene(protag, SceneManager.GetSceneByBuildIndex(sceneIndex));
            /*
            if (sceneIndex == 0)
            {
                DestroyObject(player.gameObject);
            }
            else
            {
                DontDestroyOnLoad(player);
            }*/

        }
    }
   
}
