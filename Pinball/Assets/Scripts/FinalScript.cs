using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalScript : MonoBehaviour
{
	public Text score;
	
	// Use this for initialization
	void Start ()
	{
		score.text = string.Format("Your score: {0}", GameManager.score.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Click()
	{
		GameManager.score = 0;
		GameManager.lives = 3;
		SceneManager.LoadScene("Pinball");
	}
}
