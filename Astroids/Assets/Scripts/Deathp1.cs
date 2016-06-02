using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Deathp1 : MonoBehaviour {
    
    private int life;

    void Start()
    {
        life = 5;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyShip"))
        {
            life-=1;
            if (life == 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
