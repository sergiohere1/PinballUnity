using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchScript : MonoBehaviour
{

	public GameObject arch;
	private Color archColor;
	public int points = 0;
	
	void Start () {
		archColor = arch.gameObject.GetComponent<MeshRenderer>().material.GetColor("_Color");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.Equals("Ball"))
		{
			arch.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
			arch.GetComponent<AudioSource>().Play();
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag.Equals("Ball"))
		{
			arch.GetComponent<MeshRenderer>().material.SetColor("_Color", archColor);
			GameManager.score += points;
		}
	}
}
