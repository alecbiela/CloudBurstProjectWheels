using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{
	public Vector3 position;
	public Vector3 velocity;
	public Vector3 acceleration;

	private Rigidbody2D rigidB;
	public float pushForce = 5.0f;
	public float chaseSpeed = 3.0f;

	public GameObject target;
	private Player playerInfo;

	// Use this for initialization
	void Start () 
	{
		position = transform.position;

		// Error Control
		if (target.tag != "Player") 
		{
			Debug.Log ("Missing the player game object on the Enemy script.");
			Debug.Break ();
		}

		playerInfo = target.GetComponent<Player> ();
		if (playerInfo == null) 
		{
			Debug.Log ("The assigned target is missing a 'Player' script.");
			Debug.Break ();
		}

		rigidB = gameObject.GetComponent<Rigidbody2D> ();
		if (rigidB == null) 
		{
			Debug.Log ("Missing a RigidBody2D component on the enemy.");
			Debug.Break ();
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		Seek ();
	}

	void Seek()
	{
		if (Mathf.Abs (gameObject.transform.position.x - target.transform.position.x) <= 30.0f) 
		{
			if (gameObject.transform.position.x < target.transform.position.x) 
			{
				position.x += chaseSpeed * Time.deltaTime;
			}
			else 
			{
				position.x -= chaseSpeed * Time.deltaTime;
			}
		}

		transform.position = position;
	}

	void OnCollisionEnter2D(Collision2D playerBox)
	{
		if (playerBox.gameObject.tag == "Player") 
		{
			rigidB.AddForce (new Vector2 (rigidB.velocity.x * pushForce * -1.0f, 0.0f));
			target.GetComponent<Rigidbody2D>().AddForce (new Vector2 (playerInfo.Velocity.x * pushForce * -1.0f, 0.0f));
		}
	}

}
