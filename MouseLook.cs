using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {
	private Vector2 mouseLook;
	private Vector2 smoothV;
	private GameObject character;
	public float sensitivity = 1.0f;
	public float smoothing = 2.0f;

	public static MouseLook instance;
	// Use this for initialization
	void Start () 
	{
		if (!instance) instance = this;
		else Destroy(this);
		character = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	public void FixedUpda () 
	{
		var m = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));
		m = Vector2.Scale(m,new Vector2(sensitivity * smoothing , sensitivity * smoothing));
		smoothV.x = Mathf.Lerp (smoothV.x, m.x, 1f / smoothing);	
		smoothV.y = Mathf.Lerp (smoothV.x, m.y, 1f / smoothing);	
		mouseLook += smoothV;
		mouseLook.y = Mathf.Clamp(mouseLook.y,-90f,90f);
		transform.localRotation = Quaternion.AngleAxis (-mouseLook.y, Vector3.right);
		character.transform.localRotation = Quaternion.AngleAxis (mouseLook.x, character.transform.up);
	}
}
