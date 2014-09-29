using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
	public Vector2 force = new Vector2(100,100);

	// Use this for initialization
	void Start ()
	{
		rigidbody2D.AddForce(force);
	}

	// Update is called once per frame
	void Update ()
	{
		
	}
}
