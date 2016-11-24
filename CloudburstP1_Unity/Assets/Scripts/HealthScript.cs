using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthScript : MonoBehaviour {

    public Player player;
    private float health;
	
    // Use this for initialization
	void Start ()
    {
        health = player.health;
	}
	
	// Update is called once per frame
	void Update ()
    {
        health = player.health;

        if (health <= 0)
        {
            health = 0;
        }

        GetComponent<Text>().text = health.ToString();
	}
}
