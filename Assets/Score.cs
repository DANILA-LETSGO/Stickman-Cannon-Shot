using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int score = 0;
	public GameObject text_score; // из инспектора.


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		text_score.gameObject.GetComponent<Text> ().text = score.ToString ();
		//text_score.text = score.ToString ();
		
	}
}
