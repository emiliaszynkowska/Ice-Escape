using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    static int highScore = 0;
    private Text scoreText;

    public static void SetHighScore()
    {
        highScore = score;
    }
    
    public static void AddPoint()
    {
        score += 1;
        if (score > highScore)
            highScore = score;
    }

    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
    }
    
    void Update()
    {
        scoreText.text = "Score: " + score + "\nHigh Score: " + highScore;
    }
}
