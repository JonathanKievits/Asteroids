using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OOBCounter : MonoBehaviour {
    float timeLeft = 300.0f;

    public GameObject OoBScreen;
    public Text text;
    private bool isShowing;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "OutOfBounds")
        {
            isShowing = !isShowing;
            OoBScreen.SetActive(isShowing);
            timeLeft -= Time.deltaTime;
            text.text = "Time Left" + Mathf.Round(timeLeft);
            if(timeLeft < 0)
            {
                //Load The Death Scene
            }
        }
    }
}
