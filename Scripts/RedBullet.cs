﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBullet : MonoBehaviour {
	public float speed;
	private Rigidbody2D _mybody;
	// Use this for initialization
	void Awake () {
		_mybody = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		_mybody.velocity = new Vector2 (_mybody.velocity.x, -speed);
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
