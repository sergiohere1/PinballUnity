///////////////////////////////////////////
// Práctica: Pinball
// Alumno/a: Sergio García-Consuegra Berná
// Curso: 2017/2018
// Fichero: FinalScript.cs
///////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalScript : MonoBehaviour
{
	/// <summary>
	/// Texto con nuestra puntuación
	/// </summary>
	public Text score;
	
	// Use this for initialization
	void Start ()
	{
		score.text = string.Format("Your score: {0}", GameManager.score.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// Método encargado de resetear la partida una vez el usuario haga click en Retry.
	/// </summary>
	public void Click()
	{
		GameManager.score = 0;
		GameManager.lives = 3;
		SceneManager.LoadScene("Pinball");
	}
}
