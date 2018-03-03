using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed = 10;

	private Vector3 dir;

	private static Movement inst;

	public static Movement Inst {
		get {
			if (inst == null) {
				inst = GameObject.FindObjectOfType<Movement> ();
			}
			return inst;
		}
	}

	// Use this for initialization
	void Start () {
		dir = Vector3.zero;
		
	}

	public void Chck(){
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			if (dir == Vector3.forward)
				dir = Vector3.left;
			else
				dir = Vector3.forward;
		}

		float amountToMove = speed * Time.deltaTime;
		transform.Translate (dir * amountToMove);
	}
}
