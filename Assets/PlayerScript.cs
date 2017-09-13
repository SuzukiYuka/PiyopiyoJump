using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
	int score = 0;
	// Use this for initialization
	void Start ()
	{
		
	}
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.Space)) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0, 6, 0);
			GetComponent<AudioSource> ().Play ();
		}
	}

	void OnCollisionEnter (Collision other)
	{
		Debug.Log ("Gameover");
	}

	void OnTriggerEnter (Collider other)
	{
		score++;
		Debug.Log ("スコアは" + score);
	}

	//tab2回で補完

}
