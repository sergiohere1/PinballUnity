///////////////////////////////////////////
// Práctica: Pinball
// Alumno/a: Sergio García-Consuegra Berná
// Curso: 2017/2018
// Fichero: ThrowScript.cs
///////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script encargado de funcionar como impulsador, es decir, una vez la bola contacta con el trigger, le aplica
/// una fuerza que le impulsa hacia adelante (hacia arriba si nos fijamos desde la perspectiva de la cámara).
/// </summary>
public class ThrowScript : MonoBehaviour
{
	public int throwPower = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.Equals("Ball"))
		{
			other.gameObject.GetComponent<Rigidbody>().AddForce(throwPower * Vector3.forward);
		}
	}
}
