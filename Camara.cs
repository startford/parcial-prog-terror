using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {
	
	public Transform posicion1;

	void Start () 
	{
		//posicion1 = this.transform.position;
		posicion1 = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Player.num == 12) 
		{
			
			//(-14.99,-0.07,-25.13);
		}
	}
	public void pos1()
	{
		//this.transform.position = posicion1;
	}
}
