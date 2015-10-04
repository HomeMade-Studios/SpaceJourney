using UnityEngine;
using System.Collections;
using CnControls;

public class SpaceShip : MonoBehaviour
{

	float acceleration, maxSpeed;
	float lastRotationAxisX, lastRotationAxisY;
	Rigidbody2D phys;

	void Awake()
	{
		acceleration = 5;
		maxSpeed = 5;
		phys = gameObject.GetComponent<Rigidbody2D>();
	}

	void Start()
	{

	}

	void Update()
	{
		Rotate();
		Fire();
	}

	void FixedUpdate()
	{
		Move();
	}

	void Rotate()
	{
		float angle;

		if (CnInputManager.GetAxis("HorizontalFire") == 0 && CnInputManager.GetAxis("VerticalFire") == 0)
		{
			if (CnInputManager.GetAxis("HorizontalMovement") != 0 || CnInputManager.GetAxis("VerticalMovement") != 0)
			{
				lastRotationAxisX = CnInputManager.GetAxis("HorizontalMovement");
				lastRotationAxisY = CnInputManager.GetAxis("VerticalMovement");
			}
		}
		else
		{
			lastRotationAxisX = CnInputManager.GetAxis("HorizontalFire");
			lastRotationAxisY = CnInputManager.GetAxis("VerticalFire");
		}

		angle = Mathf.Atan2(-lastRotationAxisX, lastRotationAxisY) * Mathf.Rad2Deg;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 2f);

	}

	void Move()
	{
		float x, y;

		x = CnInputManager.GetAxis("HorizontalMovement");
		y = CnInputManager.GetAxis("VerticalMovement");

		if (phys.velocity.magnitude < maxSpeed)
		{
			phys.AddForce(new Vector2(x * acceleration, y * acceleration), ForceMode2D.Force);
		}
	}

	void Fire()
	{
		

		
	}
}
