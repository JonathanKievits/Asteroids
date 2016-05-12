using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {
    public Text hScoreText;
    public Text scoreText;
    private float highScore;
    private int score;

    void Start() {
        highScore = PlayerPrefs.GetFloat("High Score");
    }

    void Update() {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("High Score", highScore);
        }
        hScoreText.text = "Highscore: " + highScore.ToString("f0");
        scoreText.text = "Score: " + score.ToString();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            hitpoints();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    void hitpoints()
    {
        score +=1;
    }
}
