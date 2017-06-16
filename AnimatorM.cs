using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorM : MonoBehaviour {

	Animator _animator;
	public static AnimatorM instance;

	void Start () 
	{
		if (!instance) instance = this;
		else Destroy(this);
		_animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	public void FixedUpda () {
		if (Input.GetMouseButton (0))_animator.SetBool ("agarrar", true);else _animator.SetBool("agarrar",false);




	}
}
