using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class Susto : MonoBehaviour{
	

	public NavMeshAgent agent;

	public AudioSource sonidos;
	public GameObject targetHero;




	// Use this for initialization
	void Start ()
	{
		agent = this.GetComponent<NavMeshAgent>();
		sonidos = this.GetComponent<AudioSource>();

	}
	public void activaSpeed()
	{
		agent.speed = 300;
		sonidos.volume = 1;


	}
	public void OnTriggerEnter(Collider c)
	{
		
		if(c.gameObject.tag == "enemy" )
		{
			destroy ();

		}
	}
	void Update () 
	{
		
			agent.SetDestination(targetHero.transform.position);







		if (Player.num == 60) 
		{

			activaSpeed ();
		}
	}
	void destroy()
	{
		Destroy (gameObject);
	}
}
