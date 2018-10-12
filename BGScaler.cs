using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var worldHeight = Camera.main.orthographicSize * 2;
		var worldWidth = worldHeight * Screen.width / Screen.height;
		transform.localScale = new Vector3 (worldWidth, worldHeight, 0);
	}

}
