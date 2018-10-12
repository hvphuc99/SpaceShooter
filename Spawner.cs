using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	[SerializeField]private GameObject _enemy;
	private float minX, maxX;
	private BoxCollider2D box;
	// Use this for initialization
	void Awake() {
		box = GetComponent<BoxCollider2D> ();
	}

	void Start () {
		StartCoroutine (SpawnerEnemy ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnerEnemy() {
		yield return new WaitForSeconds (Random.Range (1f,1.1f));
		minX = - box.bounds.size.x/2f;
		maxX = box.bounds.size.x/2f;
		Vector3 temp = transform.position;
		temp.x = Random.Range (minX, maxX);
		Instantiate (_enemy, temp, Quaternion.identity);
		StartCoroutine (SpawnerEnemy ());
	}
}
