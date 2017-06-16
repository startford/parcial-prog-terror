using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramp : MonoBehaviour {
	public Vector3 posicion1;
	public Vector3 posicion2;
	public Transform niñ;
	public GameObject niña;
	public AudioSource audioNiña;
	public bool exp = true;
	// Use this for initialization
	void Start () 
	{
		audioNiña = this.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Player.num == 70) 
		{
			audioNiña.volume = 1;
		}
		if (Player.num == 40 && exp == true)
		{
			Debug.Log ("aaaaaaaaaaa");
			pos2 ();//-2.43 6.2644 7.1   0  -53.515  0

			exp = false;
			//Player.num = 27;
		}
		if (Player.num == 9)
		{
			destroy ();

		}
		if (Player.num == 3)
		{
			//Debug.Log ("aaaaaaaaaaa");
			//pos2 ();//-2.43 6.2644 7.1   0  -53.515  0
			//audioNiña.volume = 0;
			//Player.num = 6;
			destroy();
		
		}
	}
	public void pos2()
	{
		this.transform.position = posicion2;
		niñ.Rotate (0,90,0);
	}

	void destroy()
	{
		
		Destroy (gameObject);
	}
}
