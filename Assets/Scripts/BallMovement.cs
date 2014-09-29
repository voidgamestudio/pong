using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
	public int Speed = 1;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		var x = transform.position.x;
		var y = transform.position.y;
		var z = transform.position.z;

		var newX = x;
		var newY = y;

		if (Input.GetKey (KeyCode.W)) 
		{
			newY = y + Speed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.S)) 
		{
			newY = y - Speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			newX = x + Speed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.A)) 
		{
			newX = x - Speed * Time.deltaTime;
		}

		transform.position = new Vector3(newX, newY, z);
	}
}
