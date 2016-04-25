using UnityEngine;
using System.Collections;

public class CameraRFollow : MonoBehaviour
{
    public GameObject target;

    void LateUpdate()
    {
        transform.LookAt(target.transform);
    }
}
