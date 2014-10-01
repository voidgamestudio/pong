using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
    public float speed = 10f;
    public Color collisionColor = new Color(1.0f, 0.6f, 0.6f);
	private GameController gameController;

    // Use this for initialization
    void Start()
    {
		gameController = GameObject.Find ("GameController").GetComponent<GameController>();
		transform.position = new Vector3(0, 0, 0);
		rigidbody2D.velocity = Vector2.one.normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().color = collisionColor;
            Invoke("CancelColor", 1.0f);
        } else if (collisionInfo.collider.gameObject.name == "LeftBoundary") 
		{
			gameController.UpdateRedScore();
		} else if (collisionInfo.collider.gameObject.name == "RightBoundary") {
			gameController.UpdateGreenScore();
		}
    }

    void CancelColor()
    {
        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
    }

    
}
