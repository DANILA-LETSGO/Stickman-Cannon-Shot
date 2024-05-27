using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour {

	int timer = 0;
	bool stoped = false;

	public Vector2 force; // из скрипта пушки.

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody2D> ().AddForce (force);
		Camera.main.GetComponent<SmoothCamera> ().target = transform;
	}
	
	// Update is called once per frame
	void Update () {
		//print (gameObject.GetComponent<Rigidbody2D> ().velocity);
		if (gameObject.GetComponent<Rigidbody2D> ().velocity.magnitude < 0.1f) {
			timer = timer + 1;
			if (timer >= 200) {
				if (stoped == false) {
				    GameObject canvas = GameObject.Find ("Canvas");
					canvas.gameObject.GetComponent<UI> ().GameOver ();
					stoped = true;
					print ("Game Over");
				}

			}
				
		}
			
	}

	void OnTriggerEnter2D(Collider2D col) {
		//print (col.name);
		if (col.name == "Bonus Speed") {
			gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (500,100));
		}
	}

}
