using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cannon : MonoBehaviour {
	
	public GameObject cannon_ball; // из инспектора.
	public Transform point_spawn_ball; // из инспектора.
	public GameObject force_f; // из инспектора.
	bool shoted = false;
	int current_force_x = 500;
	int current_force_y = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (shoted == false) { // проверка выстрела :D
			if (Input.GetKey (KeyCode.F)) {
				force_f.SetActive (true);
				current_force_x = current_force_x + 25;
				current_force_y = current_force_y + 5;
				force_f.gameObject.GetComponent<Text> ().text = current_force_x.ToString ();
				if (current_force_x >= 4000) {
					if (current_force_y >= 800) {
						current_force_x = 500;
						current_force_y = 100;
					}
				}
			

			}
			if (Input.GetKeyUp (KeyCode.F)) {
				GameObject cannon_ball_clone;
				cannon_ball_clone = Instantiate (cannon_ball, point_spawn_ball.position, Quaternion.identity);
				shoted = true; // Выстрел произошёл.
				Vector2 force = new Vector2 (current_force_x, current_force_y);
				cannon_ball_clone.GetComponent<CannonBall> ().force = force;
				gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-200, 0));
			}
		}
	}
}
