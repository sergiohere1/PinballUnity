///////////////////////////////////////////
// Práctica: Pinball
// Alumno/a: Sergio García-Consuegra Berná
// Curso: 2017/2018
// Fichero: ArchScript.cs
///////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Scrpt encargado de que se iluminen los arcos una vez la bola pasa justo por debajo de ellos, gracias a la
/// activación de un Trigger.
/// </summary>
public class ArchScript : MonoBehaviour
{
	/// <summary>
	/// El arco que queremos que se ilumine, en este caso, el arco por el que pasará la bola (Lo asignamos en el
	/// Editor)
	/// </summary>
	public GameObject arch;
	/// <summary>
	/// El color original del arco
	/// </summary>
	private Color archColor;
	/// <summary>
	/// Puntos que da pasar por dicho arco. Como esta manera de obtener puntos es diferente a la de SumScore,
	/// no podremos reutilizarlo.
	/// </summary>
	public int points = 0;
	
	/// <summary>
	/// Al comienzo guardamos el color original del Arco.
	/// </summary>
	void Start () {
		archColor = arch.gameObject.GetComponent<MeshRenderer>().material.GetColor("_Color");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// Método que se activará una vez que la bola interactúe con cada Trigger situado debajo de cada Arco, lo que
	/// ocasionará que dichos arcos cambien de color a medida que la bola pasa por debajo de ellos.
	/// </summary>
	/// <param name="other">El collider que activa el Trigger</param>
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.Equals("Ball"))
		{
			arch.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
			arch.GetComponent<AudioSource>().Play();
		}
	}

	/// <summary>
	/// Una vez que la bola haya salido del Trigger, devolvemos a cada arco su color original.
	/// </summary>
	/// <param name="other">El collider que activa el Trigger</param>
	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag.Equals("Ball"))
		{
			arch.GetComponent<MeshRenderer>().material.SetColor("_Color", archColor);
			GameManager.score += points;
		}
	}
}
