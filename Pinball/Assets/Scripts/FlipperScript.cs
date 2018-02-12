using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperScript : MonoBehaviour {
	/// <summary>
	/// Ángulo de posición en descanso
	/// </summary>
	public float restPosition = 0f;
	/// <summary>
	/// Ángulo de posición una vez presionado
	/// </summary>
	public float pressedPosition = 45f;
	/// <summary>
	/// Fuerza del golpe del impacto
	/// </summary>
	public float hitStrength = 10000f;
	/// <summary>
	/// Fuerza del flipper.
	/// </summary>
	public float flipperDamper = 150f;
	/// <summary>
	/// Nombre de la entrada
	/// </summary>
	public string inputName;

	HingeJoint hingeJoint;

	// Use this for initialization
	void Start () {
		hingeJoint = GetComponent<HingeJoint>();
		hingeJoint.useSpring = true;
	}
	
	// Update is called once per frame
	void Update () {
		// Variable para controlar nuestro spring del HingeJoint
		JointSpring spring = new JointSpring();
		// Fuerza del muelle
		spring.spring = hitStrength;
		// Velocidad con la que se mueve
		spring.damper = flipperDamper;

		if (Input.GetAxis (inputName) == 1) {
			spring.targetPosition = pressedPosition;
		} else {
			spring.targetPosition = restPosition;
		}

		hingeJoint.spring = spring;
		hingeJoint.useLimits = true;
	}
}
