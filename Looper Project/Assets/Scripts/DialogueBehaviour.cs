using UnityEngine;
using System.Collections;

public class DialogueBehaviour : MonoBehaviour {


	// Upon Activation of trigger
	void OnTriggerEnter2D(Collider2D other) {
		if (other.name == "dialogueBox") {
			SpriteRenderer r = other.gameObject.GetComponent<SpriteRenderer> ();
			Color c = r.material.color;
			c.a = 1.0f;
			r.material.color = c;
	 	}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.name == "dialogueBox") {
			SpriteRenderer r = other.gameObject.GetComponent<SpriteRenderer> ();
			Color c = r.material.color;
			r.material.color = new Color(c.r, c.g, c.b, 0.0f);
		}
	}
}
