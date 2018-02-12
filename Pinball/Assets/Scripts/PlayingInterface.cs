///////////////////////////////////////////
// Práctica: Pinball
// Alumno/a: Sergio García-Consuegra Berná
// Curso: 2017/2018
// Fichero: PlayingInterface.cs
///////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Script para que se cargue la interfaz de pantalla en la Escena del Pinball, mostrando las vidas y la puntuación.
/// </summary>
public class PlayingInterface : MonoBehaviour {
    /// <summary>
    /// Texto que mostrará la puntuación actual.
    /// </summary>
	public Text currentScore;
    /// <summary>
    /// Texto que mostrará el número de vidas actual.
    /// </summary>
    public Text currentLives;
    
    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        currentScore.text = string.Format("Score: {0}" , GameManager.score.ToString());
        currentLives.text = string.Format ("Lives: x{0}", GameManager.lives.ToString());
    }
}
