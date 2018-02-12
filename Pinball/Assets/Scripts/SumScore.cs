using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumScore : MonoBehaviour {
	private Color rockColor;

	public int pointsValue = 0;
	// Use this for initialization
	void Start () {
		rockColor = gameObject.GetComponent<MeshRenderer>().material.GetColor("_Color");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnCollisionEnter(Collision collision)
	{
		//Si ha chocado con un cubo...
		if(collision.gameObject.tag.Equals("Ball")){
			
			gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.gray);
			gameObject.GetComponent<AudioSource>().Play();
		}        
	}

	private void OnCollisionExit(Collision collision)
	{
		if(collision.gameObject.tag.Equals("Ball"))
		{
			gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", rockColor);
			gameObject.GetComponent<AudioSource>().Play();
			GameManager.score+=pointsValue;
		}
	}
}
