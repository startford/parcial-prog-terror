using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : Player {


	void Start () 
	{
		
	}
	

	void FixedUpdate () 
	{
		if(num == 1)
		{

			destroy();
			num = 2;
		}
	}

	public void destroy()
	{
		
		Destroy(gameObject);
	}
}
