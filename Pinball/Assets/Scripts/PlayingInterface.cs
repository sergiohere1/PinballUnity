using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayingInterface : MonoBehaviour {

	public Text currentScore;
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
