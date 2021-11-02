using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void GoToIceRink()
    {
        SceneManager.LoadScene("IceRink");
    }

    public void GoToLockers()
    {
        SceneManager.LoadScene("Lockers");
    }
}
