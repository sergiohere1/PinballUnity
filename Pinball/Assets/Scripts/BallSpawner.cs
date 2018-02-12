using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSpawner : MonoBehaviour
{
	// Bolas totales que se spawnearán
	public GameObject ball;
	//Número de vidas actual
	private int currentLives;
	//Variable para controlar si ha finalizado la puntuación o no.

	// Use this for initialization
	void Start () {
		Instantiate(ball);
		currentLives = GameManager.lives;
	}
	
	// Update is called once per frame
	void Update () {
			if (GameManager.lives != currentLives && GameManager.lives!=0)
			{
				Instantiate(ball);
				currentLives = GameManager.lives;
			}else if(GameManager.lives == 0)
			{
				Invoke("LoadEndScene", 0.5f);
			}	
	}

	void LoadEndScene()
	{
		SceneManager.LoadScene("FinalScene");
	}
	
}
