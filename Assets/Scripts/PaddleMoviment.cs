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
	void Update () {

		var x = transform.position.x;
		var y = transform.position.y;
		var z = transform.position.z;

		var newY = y;

		if (Input.GetKey (upKey)) {
			newY = y + Speed * Time.deltaTime;

		} else if(Input.GetKey (downKey)){
			newY = y - Speed * Time.deltaTime;
		}

		transform.position = new Vector3(x, newY, z);
	}
}
