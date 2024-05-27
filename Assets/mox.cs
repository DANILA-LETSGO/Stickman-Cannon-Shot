using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class mox : MonoBehaviour {

	int CurrentForceY = 100;
	int CurrentForceX = 100*5;
	bool MK10 = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (MK10 == false) {
			
			if (Input.GetKey (KeyCode.H)) {
				CurrentForceY = CurrentForceY + 5;
				CurrentForceX = CurrentForceX + (5 * 5);
				// Нам без разницы)) Если выполняется одно, значит выполнилось и другое.
				if (CurrentForceY == 800) {
					CurrentForceY = 100;
					CurrentForceX = 100 * 5;
				}
			}
			if (Input.GetKeyUp (KeyCode.H)) {
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (CurrentForceX, CurrentForceY));
				MK10 = true;
			}
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene (0);
		}

	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.name == "Bonus Speed") {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (CurrentForceX, CurrentForceY));
		}
	}
}
