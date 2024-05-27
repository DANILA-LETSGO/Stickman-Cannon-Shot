using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickPart : MonoBehaviour {

	int timer = 0;
	bool collised = false;

	public GameObject score_manager; // из инспектора.

	void OnCollisionEnter2D(Collision2D col) {
		//print (col.collider.name);	
		if (col.collider.name == "Cannon Ball(Clone)") {
			gameObject.GetComponent<SpriteRenderer>().color = new Color(0.8f,0,0);
			collised = true;
			score_manager.gameObject.GetComponent<Score> ().score += 1; 
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (collised == true) {
			timer = timer + 1;
			timer += 1;
			if (timer >= 50) {
				gameObject.GetComponent<SpriteRenderer>().color = new Color(0,0,0);
			}
		}
		
	}
}
