using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	private Rigidbody2D _mybody;
	[SerializeField] private GameObject _bullet;
	// Use this for initialization
	void Awake () {
		_mybody = GetComponent<Rigidbody2D> ();

	}
	void Start() {
		StartCoroutine (Shoot ());
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxis ("Horizontal")*speed;
		float v = Input.GetAxis ("Vertical")*speed;
		_mybody.velocity = new Vector2 (h,v);
	}
	IEnumerator Shoot() {
		yield return new WaitForSeconds (.2f);
		Vector3 temp = transform.position;
		temp.y += 0.5f;
		Instantiate (_bullet, temp, Quaternion.identity);
		StartCoroutine (Shoot ());
	}
}
