using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {

    public Camera MainCamera;
    public Camera TPCamera;

	// Use this for initialization
	void Start () {
        
       MainCamera.enabled = true;
        TPCamera.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.R))
        {
            MainCamera.enabled = !MainCamera.enabled;
            TPCamera.enabled = !TPCamera.enabled;
        }
	
	}
}
