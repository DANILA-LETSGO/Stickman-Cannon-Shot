using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickman : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col) {
		if (col.name == "Cannon Ball(Clone)") {
			//print ("ХУЙ");
			transform.GetChild(0).gameObject.GetComponent<Rigidbody2D>().simulated = true; 
			transform.GetChild(1).gameObject.GetComponent<Rigidbody2D>().simulated = true;
			transform.GetChild(2).gameObject.GetComponent<Rigidbody2D>().simulated = true;
			transform.GetChild(3).gameObject.GetComponent<Rigidbody2D>().simulated = true;
			transform.GetChild(4).gameObject.GetComponent<Rigidbody2D>().simulated = true;
			transform.GetChild(5).gameObject.GetComponent<Rigidbody2D>().simulated = true;
			transform.GetChild(6).gameObject.GetComponent<Rigidbody2D>().simulated = true;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
