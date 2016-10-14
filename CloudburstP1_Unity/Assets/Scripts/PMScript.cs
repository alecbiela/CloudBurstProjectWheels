﻿using UnityEngine;
using System.Collections;

public class PMScript : MonoBehaviour {

    public GameManager GM;

	// Use this for initialization
	void Start ()
    {
        GM.TogglePauseMenu();
    }

    // Update is called once per frame
    void Update ()
    {
        ScanForKeyStroke();
    }

    void ScanForKeyStroke()
    {
        if (Input.GetKeyDown("p"))
        {
            TogglePauseMenu();
        }
    }

    public void TogglePauseMenu()
    {
        // not the optimal way but for the sake of readability
        if (GetComponentInChildren<Canvas>().enabled)
        {
            GetComponentInChildren<Canvas>().enabled = false;
            Time.timeScale = 1.0f;
        }
        else
        {
            GetComponentInChildren<Canvas>().enabled = true;
            Time.timeScale = 0f;
        }

        Debug.Log("GAMEMANAGER:: TimeScale: " + Time.timeScale);
    }
}