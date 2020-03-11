using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public Text scoreText;
    public int maxScore = 10;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Bugs Eliminated: " + score;
    }

    public void AddPoint() {
        score++;

        if(score < maxScore) {
            scoreText.text = "Bugs Eliminated: " + score;
        } else {
            scoreText.text = "Looks like you got them all!";
            score = 0;
        }
    }
}
