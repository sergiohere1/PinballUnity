using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
