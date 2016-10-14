using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    //----------------------------------------
    // handles
    public PMScript UI;

    //-----------------------------------------
    // function definitions
    void Start()
    {

    }
    public void StartNewGame()
    {

    }

    public void TogglePauseMenu()
    {
        // not the optimal way but for the sake of readability
        if (UI.GetComponentInChildren<Canvas>().enabled)
        {
            UI.GetComponentInChildren<Canvas>().enabled = false;
            Time.timeScale = 1.0f;
        }
        else
        {
            UI.GetComponentInChildren<Canvas>().enabled = true;
            Time.timeScale = 0f;
        }

        Debug.Log("GAMEMANAGER:: TimeScale: " + Time.timeScale);
    }

}
