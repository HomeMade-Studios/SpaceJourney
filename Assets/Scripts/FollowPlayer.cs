using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	Transform playerSpaceShip;
	Vector3 playerPosition;

	void Awake () {
		playerSpaceShip = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void FixedUpdate () {

		playerPosition = new Vector3(playerSpaceShip.position.x, playerSpaceShip.position.y, -10f);
		transform.position = Vector3.Lerp(transform.position, playerPosition, 3f * Time.deltaTime);
	}
}
