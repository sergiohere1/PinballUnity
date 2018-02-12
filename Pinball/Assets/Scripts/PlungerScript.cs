﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerScript : MonoBehaviour {
	/// <summary>
	/// Fuerza máxima que se le dará al slider
	/// </summary>
	public float maxPower = 50f;
	/// <summary>
	/// El power Slider asignado
	/// </summary>
	public Slider powerSlider;

	float power;
	List<Rigidbody> ballList;
	bool ballReady;

	// Use this for initialization
	void Start () {
		powerSlider.minValue = 0F;
		powerSlider.maxValue = maxPower;
		ballList = new List<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (ballReady) {
			powerSlider.gameObject.SetActive (true);
		}else{
			powerSlider.gameObject.SetActive (false);
		}

		powerSlider.value = power;

		if (ballList.Count > 0) {
			ballReady = true;
			if (Input.GetKey (KeyCode.Space)) {
				if (power < maxPower) {
					power += 50 * Time.deltaTime;
				}
			}


			if (Input.GetKeyUp (KeyCode.Space)) {
				foreach (Rigidbody r in ballList) {
					r.AddForce (power * Vector3.forward);
				}
			}
		} else {
			ballReady = false;
			power = 0f;
		}


	}

	private void OnTriggerEnter(Collider other){
	
		if (other.gameObject.CompareTag ("Ball")) {
			ballList.Add(other.gameObject.GetComponent<Rigidbody>());
		}
	}

	private void OnTriggerExit(Collider other){
		if (other.gameObject.CompareTag ("Ball")) {
			ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
			power = 0f;
		}

	}

}
