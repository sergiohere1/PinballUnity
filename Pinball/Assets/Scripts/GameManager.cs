///////////////////////////////////////////
// Práctica: Pinball
// Alumno/a: Sergio García-Consuegra Berná
// Curso: 2017/2018
// Fichero: GameManager.cs
///////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Clase que almacenará variables estáticas referentes al número de vidas y a la puntuación actual del usuario.
/// </summary>
public static class GameManager
{
	/// <summary>
	/// Puntuación del usuario.
	/// </summary>
	public static int score = 0;
	/// <summary>
	/// Vidas del usuario.
	/// </summary>
	public static int lives = 3;
}
