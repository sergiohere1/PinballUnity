///////////////////////////////////////////
// Práctica: Pinball
// Alumno/a: Sergio García-Consuegra Berná
// Curso: 2017/2018
// Fichero: LostLive.cs
///////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script encargado de restar vidas al usuario una vez que la bola cae fuera del tablero.
/// </summary>
public class LostLive : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Ball"))
		{
			GameManager.lives--;
			Destroy(other);
		}
	}
}
