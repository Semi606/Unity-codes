using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void Update()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }
}
