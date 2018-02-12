///////////////////////////////////////////
// Práctica: Pinball
// Alumno/a: Sergio García-Consuegra Berná
// Curso: 2017/2018
// Fichero: SumScore.cs
///////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Método encargado de iluminar un Flipper (Objeto puntuable del Pinball) con el que colisione la bola y
/// sumar a la puntuación del usuario el valor que nosotros le asignemos.
/// </summary>
public class SumScore : MonoBehaviour {
	/// <summary>
	/// Color original del GameObject.
	/// </summary>
	private Color objectColor;
	/// <summary>
	/// Puntuación que dará el colisionar con este objeto.
	/// </summary>
	public int pointsValue = 0;
	
	// Use this for initialization
	void Start () {
		objectColor = gameObject.GetComponent<MeshRenderer>().material.GetColor("_Color");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	/// <summary>
	/// Método llamado una vez se registre colisión con este objeto, si es la bola, cambiamos su color.
	/// </summary>
	/// <param name="collision">Objeto que colisiona con el objeto que posea este Script.</param>
	private void OnCollisionEnter(Collision collision)
	{
		// Si ha chocado con la bola...
		if(collision.gameObject.tag.Equals("Ball")){
			gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.gray);
			gameObject.GetComponent<AudioSource>().Play();
		}        
	}

	/// <summary>
	/// Una vez la bola sale del rango de colisión, devolvemos su color al original e incrementamos la puntuación del
	/// marcador.
	/// </summary>
	/// <param name="collision">El objeto que ha colisionado con nuestro GameObject.</param>
	private void OnCollisionExit(Collision collision)
	{
		if(collision.gameObject.tag.Equals("Ball"))
		{
			gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", objectColor);
			gameObject.GetComponent<AudioSource>().Play();
			GameManager.score+=pointsValue;
		}
	}
}
