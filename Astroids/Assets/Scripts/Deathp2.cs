using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Deathp2 : MonoBehaviour {

    private int score;

    void Start()
    {
        score = 5;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            score--;
            if (score == 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
