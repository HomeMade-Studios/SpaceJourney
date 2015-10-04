using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	Rigidbody2D phys;

	void Awake() {
		phys = GetComponent<Rigidbody2D>();
	}

	void Start() {
		SetRandomForce();
    }

	void OnTriggerExit2D(Collider2D other) {
		if(other.gameObject.tag == "AsteroidsController") {
			Destroy(gameObject);
		}
	}

	void SetRandomForce() {
		Vector2 movementForce;
		float torqueForce;

		movementForce = new Vector2(Random.Range(1f, 4f), Random.Range(1f, 4f));
		phys.AddForce(movementForce, ForceMode2D.Impulse);

		torqueForce = Random.Range(1f, 25f);
		phys.AddTorque(torqueForce);
 
	}
	
}
