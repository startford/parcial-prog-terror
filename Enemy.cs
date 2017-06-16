using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class Enemy : Player {
	public GameObject[] allTargets;
	public GameObject[] allTargets2;
	public int currentTargetIndex;
	public NavMeshAgent agent;
	public GameObject target;
	public AudioSource sonidos;
	public GameObject targetHero;

	public static Enemy instance;

	public int atakeFinal = 0;
	public static int atakeAnimacion = 0;


	// Use this for initialization
	void Start ()
	{
		agent = this.GetComponent<NavMeshAgent>();
		sonidos = this.GetComponent<AudioSource>();
		if (!instance) instance = this;
		else Destroy(this);
	}
	public void activaSpeed()
	{
		agent.speed = 3;
		sonidos.volume = 1;


	}
	public void OnTriggerEnter(Collider c)
	{
		if(c.gameObject.layer == 22 )
		{
			print ("perdiste");
			atakeFinal = 1;
			atakeAnimacion = 1;

		}
		if(c.gameObject.tag == "enemy" )
		{
			Cursor.lockState = CursorLockMode.None;
			reinicio ();
			SceneManager.LoadScene(5);

		}
	}
	public void FixedUpda () 
	{
		if (atakeFinal == 1) 
		{
            agent.SetDestination(targetHero.transform.position);
            Debug.Log ("me miraste feo");
		}
		//agent.SetDestination(target.transform.position);

		if (num != 50) {
			if (agent.remainingDistance == 0) {
			
				agent.SetDestination (allTargets [currentTargetIndex].transform.position);
				currentTargetIndex++;
				if (currentTargetIndex >= allTargets.Length) {
					currentTargetIndex = 0;
				}	
				
			}
		}
		if (num == 50) {
			if (agent.remainingDistance == 0) {

				agent.SetDestination (allTargets2 [currentTargetIndex].transform.position);
				currentTargetIndex++;
				if (currentTargetIndex >= allTargets.Length) {
					currentTargetIndex = 0;
				}	

			}
		}



		if (Player.num == 3) 
		{
			
			activaSpeed ();
		}
	}
}
