using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public float speed;
	private Rigidbody2D mybody;
	[SerializeField]private GameObject bullet;
	// Use this for initialization
	void Awake () {
		mybody = GetComponent<Rigidbody2D> ();
	}
	void Start() {
		StartCoroutine (EnemyShoot ());
	}
	
	// Update is called once per frame
	void Update () {
		mybody.velocity = new Vector2 (0f, -speed);
	}
	IEnumerator EnemyShoot() {
		yield return new WaitForSeconds (Random.Range (1f, 3f));
		Vector3 temp = transform.position;
		temp.y -= 0.5f; 
		Instantiate (bullet, temp, Quaternion.identity);
		StartCoroutine (EnemyShoot ());
	}
	void OnTriggerEnter2D(Collider2D target) {
		if (target.tag == "Player") {
			Destroy (target.gameObject);
			GamePlayController.instance.PlaneDiedShowPanel ();
		}
		if (target.tag == "BottomBounds")
			Destroy (gameObject);
	}
}
