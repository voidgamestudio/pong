using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    #region Public parameters

    public GUIText RedScore, GreenScore;
    public GameObject ball;

    #endregion

    #region Private attributes

    private int redScore = 0;
    private int greenScore = 0;
    private GameObject currentBall;

    #endregion


    // Use this for initialization
    void Start()
    {
        currentBall = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateRedScore()
    {
        redScore += 1;
        RedScore.text = redScore.ToString();
        Reset();
    }

    public void UpdateGreenScore()
    {
        greenScore += 1;
        GreenScore.text = greenScore.ToString();
        Reset();
    }

    public void Reset()
    {
        Destroy(currentBall);
        currentBall = (GameObject)Instantiate(ball);
    }
}
