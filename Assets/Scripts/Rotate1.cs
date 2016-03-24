using UnityEngine;
using System.Collections;

public class Rotate1 : MonoBehaviour {
	public float speed = 4f;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (0, -speed, speed);
	}
}
