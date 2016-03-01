using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	private Rigidbody2D rb; // Declares a variable of type RigidBody2D game component.



	public float speed = 10f;   // Variable that multiplies the force applied to the rigidbody.
	public float jumpVelocity = 50f; // Variable determining the sudden vertical force applied to the rigidbody.
	private Animator MyAnimator;

	public LayerMask groundLayerTest;

	void Start() // This function Attaches this script to the rigidbody that is also a  part of this scripts object.
	{
		rb = GetComponent<Rigidbody2D> (); // Gets the Rigidbody2D component that is attached to the same asset as this script.
		MyAnimator = GetComponent<Animator>();
	}





	void Update () // This function reads in the Vertical/Horizontal input of the player, and applys force to the rigidbody accordingly.
	{


		float moveHorizontal = Input.GetAxis("Horizontal") * speed;
		var moveVertical = 0f;


		if (Input.GetButtonDown ("Jump") && rb.IsTouchingLayers (groundLayerTest)) {
			moveVertical = jumpVelocity;
		}

		if (!rb.IsTouchingLayers (groundLayerTest)) {
			MyAnimator.SetBool ("Jump", true);
		} 

		else {
			MyAnimator.SetBool ("Jump", false);
		}

		if (moveHorizontal != 0) {
			MyAnimator.SetBool ("Running", true);
		} else
			MyAnimator.SetBool ("Running", false);

		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);
		rb.AddForce(movement);

	}
}
