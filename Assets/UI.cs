using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

	public GameObject panel_game_over;// из инспектора

	public void Restart () {
		SceneManager.LoadScene ("Game");
	}

	public void GameOver(){
		panel_game_over.SetActive (true);
	}
}
