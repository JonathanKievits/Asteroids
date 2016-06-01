using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {
    public Text hScoreText;
    public Text scoreText;
    private float highScore;
    [SerializeField]
    float score;

    void Start() {
        highScore = PlayerPrefs.GetFloat("High Score");
        score = 0;
    }

    void Update() {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("High Score", highScore);
        }
        scoreText.text = "Score: " + score.ToString(" ");
        hScoreText.text = "Highscore: " + highScore.ToString(" ");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            hitpoints();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    void hitpoints()
    {
        score++;
    }
}
