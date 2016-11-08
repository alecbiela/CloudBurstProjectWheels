using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    
    public Player p1;
    public Enemy e;
    private float time;
	// Use this for initialization
	void Start () {
        time = 5.0f;
        Debug.Log("Initialized!");
    }
	
	// Update is called once per frame
	void Update ()
    {
        time -= Time.deltaTime;

        if(Vector3.Distance(transform.position.normalized, p1.transform.position.normalized) <= 15.0f)
        {
            Debug.Log("Within Distance");
            if (time < 0)
            {
                Debug.Log("Spawned!");
                Instantiate(e);
                e.position = transform.position;
                time = 5.0f;
            }
        }
	}
}
