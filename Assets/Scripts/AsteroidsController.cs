using UnityEngine;
using System.Collections;

public class AsteroidsController : MonoBehaviour {

	public Object asteroid0, asteroid1, asteroid2;
	public int maxAsteroidCount;

	void Start() {
		InvokeRepeating("CheckForAsteroidsSpawn", 0f, 1f);
	}

	void Update() {

	}

	void CheckForAsteroidsSpawn() {
		if (transform.childCount < maxAsteroidCount) {
			if (Random.Range(-1, 3) > 0) {

			}
		}
	}

	void SpawnAsteroids(int quantity) {
		int asteroidSize;

		for(int i=0; i<quantity; i++) {
			asteroidSize = Random.Range(0, 2);

			switch (asteroidSize) {

			}
		}
	}
}
