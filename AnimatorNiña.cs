using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorNiña : MonoBehaviour {
	private Animator m_Animator;

	void Start () 
	{
		m_Animator = GetComponent<Animator> ();
	}
	

	void FixedUpdate () 
	{
		if (Enemy.atakeAnimacion == 1) 
		{
			m_Animator.SetBool ("atacar", true);
			Enemy.atakeAnimacion = 2;
		}
	}
}
