using UnityEngine;
using System.Collections;

public class VectorInput : MonoBehaviour {

	// a "public" var is "EXPOSED" to the inspector
	public float speed = 4.5f;

	public float shiftSpeed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//GetComponent<Transform>().position += new Vector3( 0f, 0f, 1f );

		//This code is FrameRate Dependendent
		// = Behavior will be different based on your FrameRate
		// transform.position += new Vector3( 0f, 0f, 1f );

		float actualSpeed = 0f;
		if (Input.GetKey ( KeyCode.LeftShift) ) {
			actualSpeed = shiftSpeed;
		} else {
			actualSpeed = speed;
		}

		// FRAMERATE INDEPENDENT, multiply by Time.deltaTime
		// Time.deltaTime = "fraction of a second between a frame"
		// 60 FPS >> Time.deltaTime = ~16ms
		// 10 FPS >> Time.deltaTime = ~100ms (1/6th)
		if (Input.GetKey (KeyCode.W) ) {
			transform.position += new Vector3( 0f, 0f, 1f ) * Time.deltaTime * actualSpeed;
		}

		if (Input.GetKey (KeyCode.A) ) {
			transform.position += new Vector3( -1f, 0f, 0f ) * Time.deltaTime * actualSpeed;
		}

		if (Input.GetKey (KeyCode.D) ) {
			transform.position += new Vector3( 1f, 0f, 0f ) * Time.deltaTime * actualSpeed;
		}

		if (Input.GetKey (KeyCode.S) ) {
			transform.position += new Vector3( 0f, 0f, -1f ) * Time.deltaTime * actualSpeed;
		}
	}
}
