using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    #region Public parameters

    public GUIText RedScore, GreenScore;
    public GameObject ball;
    public AudioClip godGoalSound, devilGoalSound;

    #endregion

    #region Private attributes

    private int devilScore = 0;
    private int godScore = 0;
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

    public void UpdateDevilScore()
    {
        devilScore += 1;
        RedScore.text = devilScore.ToString();
        AudioSource.PlayClipAtPoint(devilGoalSound, transform.position);
        Reset();
    }

    public void UpdateGodScore()
    {
        godScore += 1;
        GreenScore.text = godScore.ToString();
        AudioSource.PlayClipAtPoint(godGoalSound, transform.position);
        Reset();
    }

    public void Reset()
    {
        Destroy(currentBall);
        currentBall = (GameObject)Instantiate(ball);
    }
}
