using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHome : MonoBehaviour {

	// Use this for initialization
	public Light light1;
	public GameObject objetos;
	void Start () 
	{
		light1 = this.GetComponent<Light>();

	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Player.num == 20) 
		{
			light1.intensity = 0;

		}
		if (Player.num == 21) 
		{
			light1.intensity = 3;

		}
		if (Player.num == 40) 
		{
			Destroy (objetos);
			//Player.num = 42;
		}
	}
}
