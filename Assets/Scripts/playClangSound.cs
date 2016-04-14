using UnityEngine;
using System.Collections;

public class playClangSound : MonoBehaviour {
	public GameObject player;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			audioSource.Play ();
			Debug.Log ("Metal Sound");
		}
	}
}
