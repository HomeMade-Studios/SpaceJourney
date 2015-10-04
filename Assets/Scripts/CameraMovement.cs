using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	Transform playerSpaceShip;
	
	void Awake () {
		playerSpaceShip = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void FixedUpdate () {
		FollowPlayer();
	}

	void FollowPlayer()
	{
		Vector3 playerPosition;
		playerPosition = new Vector3(playerSpaceShip.position.x, playerSpaceShip.position.y, -10f);
		transform.position = Vector3.Lerp(transform.position, playerPosition, 3f * Time.deltaTime);
	}
}
