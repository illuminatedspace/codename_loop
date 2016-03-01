using UnityEngine;
using System.Collections;

public class PortalBehaviour : MonoBehaviour {
	
	// Function for when an object walks into the trigger colider (Should destroy the object).
	
	public GameObject targetPosition;
	

	void OnTriggerEnter2D(Collider2D other) {
		print ("Hit Trigger");
		//if(other.name == "Player")
		other.transform.position = targetPosition.transform.position;
	}
	
}
