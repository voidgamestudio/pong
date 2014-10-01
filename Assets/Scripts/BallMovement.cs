using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
    #region Public parameters

    public float speed = 10f;
    public Color collisionColor = new Color(1.0f, 0.6f, 0.6f);

    #endregion

    #region Private attributes

    private GameController gameController;

    #endregion


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

			// Calculate new direction of the ball
			// Calculate hit Factor
			float y = hitFactor(transform.position, collisionInfo.transform.position, ((BoxCollider2D)collisionInfo.collider).size.y);

			// Calculate the direction (left or right)
			float x = 1;
			if (collisionInfo.collider.gameObject.name == "GreenPaddle") 
			{
				x = 1;
			} else if (collisionInfo.collider.gameObject.name == "RedPaddle") 
			{
				x = -1;
			}

			// Calculate direction, set length to 1
			Vector2 direction = new Vector2(x, y).normalized;
			
			// Set Velocity with direction * speed
			rigidbody2D.velocity = direction * speed;

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

	private float hitFactor(Vector2 ballPos, Vector2 racketPos,
	                        float racketHeight) {
		// ascii art:
		// ||  1 <- at the top of the racket
		// ||
		// ||  0 <- at the middle of the racket
		// ||
		// || -1 <- at the bottom of the racket
		return (ballPos.y - racketPos.y) / racketHeight;
	}
    
}
