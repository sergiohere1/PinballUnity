///////////////////////////////////////////
// Práctica: Pinball
// Alumno/a: Sergio García-Consuegra Berná
// Curso: 2017/2018
// Fichero: BallSpawner.cs
///////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSpawner : MonoBehaviour
{
	/// <summary>
	/// Objeto que haremos aparecer.
	/// </summary>
	public GameObject ball;
	/// <summary>
	/// Número de vidas actual
	/// </summary>
	private int currentLives;
	

	// Use this for initialization
	void Start () {
		Instantiate(ball);
		currentLives = GameManager.lives;
	}
	
	// Update is called once per frame
	void Update () {
			// Mientras las vidas del GameManager sean diferentes a las actuales y distintas de 0.
			if (GameManager.lives != currentLives && GameManager.lives!=0)
			{
				Instantiate(ball);
				currentLives = GameManager.lives;
			}else if(GameManager.lives == 0)
			{
				Invoke("LoadEndScene", 0.5f);
			}	
	}

	/// <summary>
	/// Método encargado de cargar la escena tras perder. Lo hemos hecho en otro método para que pueda funcionar
	/// el método Invoke, ya que no admitía usar el SceneManager.LoadScene.
	/// </summary>
	void LoadEndScene()
	{
		SceneManager.LoadScene("FinalScene");
	}
	
}
