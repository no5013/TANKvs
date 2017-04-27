using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTextController : MonoBehaviour {

	public GameObject tank;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		Move ();
	}

	void Move () {
		transform.position = tank.transform.position;
	}
}
