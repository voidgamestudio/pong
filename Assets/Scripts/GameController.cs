using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private int redScore = 0;
	private int greenScore = 0;
	public GUIText RedScore, GreenScore;
	public GameObject ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UpdateRedScore () {
		redScore += 1;
		RedScore.text = redScore.ToString();
		Reset();
	}

	public void UpdateGreenScore () {
		greenScore += 1;
		GreenScore.text = greenScore.ToString();
		Reset();
    }

	public void Reset () {
		ball.GetComponent<BallMovement> ().InitBall();
	}
}
