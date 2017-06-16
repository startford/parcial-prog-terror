using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lintern : MonoBehaviour {
	public Light lightLint;
	// Use this for initialization
	void Start () 
	{
		lightLint = this.GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if(Input.GetKey(KeyCode.P))
		{
			lightLint.intensity = 1;

		}
		if(Input.GetKey(KeyCode.O))
		{
			lightLint.intensity = 0;

		}
	}
}
