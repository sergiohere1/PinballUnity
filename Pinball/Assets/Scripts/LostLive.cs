using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
