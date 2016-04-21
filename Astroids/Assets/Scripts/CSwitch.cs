using UnityEngine;
using System.Collections;

public class CSwitch : MonoBehaviour
{

    public Camera MainCamera2;
    public Camera TPCamera2;

    // Use this for initialization
    void Start()
    {

        MainCamera2.enabled = true;
        TPCamera2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            MainCamera2.enabled = !MainCamera2.enabled;
            TPCamera2.enabled = !TPCamera2.enabled;
        }

    }
}

