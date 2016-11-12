using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class LevelBehavior : MonoBehaviour 
{
	//Attributes
	public GameObject verticalPlatform;
	public GameObject referenceObject;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		MovingPlatformVertically();
	
	}


	void MovingPlatformVertically()
	{
		if (verticalPlatform.transform.position.y < (referenceObject.transform.position.y + 100.0f)) 
		{
			verticalPlatform.transform.position = new Vector3 (verticalPlatform.transform.position.x, verticalPlatform.transform.position.y + 5.0f *Time.deltaTime);
		} 
		else if (verticalPlatform.transform.position.y > (referenceObject.transform.position.y + 100.0f)) 
		{
			while(verticalPlatform.transform.position.y > (referenceObject.transform.position.y - 100.0f))
			{
				verticalPlatform.transform.position = new Vector3 (verticalPlatform.transform.position.x, verticalPlatform.transform.position.y - 5.0f *Time.deltaTime);
			}
		} 
	}
}
