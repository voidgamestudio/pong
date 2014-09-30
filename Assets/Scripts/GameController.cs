using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private int redScore = 0;
	private int greenScore = 0;
	public GUIText RedScore, GreenScore;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UpdateRedScore () {
		redScore += 1;
		RedScore.text = redScore.ToString();
	}

	public void UpdateGreenScore () {
		greenScore += 1;
		GreenScore.text = greenScore.ToString();
    }
}
