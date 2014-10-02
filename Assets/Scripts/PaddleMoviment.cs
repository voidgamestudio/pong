using UnityEngine;
using System.Collections;

public class PaddleMoviment : MonoBehaviour {


	public int Speed = 1;
	public KeyCode upKey;
	public KeyCode downKey;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (upKey)) {
			transform.Translate(new Vector2(0.0f, 0.1f));

		} else if(Input.GetKey (downKey)){
			transform.Translate(new Vector2(0.0f, -0.1f));
		}
	}
}
