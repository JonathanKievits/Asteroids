using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{

    public float rotationSpeed;
    public float movementSpeed;
    public float rotationTime;

    private float randomTime;

    void Start()
    {
        Invoke("ChangeRotation", rotationTime);
    }

    void ChangeRotation()
    {
        if (Random.value > 0.5f)
        {
            rotationSpeed = -rotationSpeed;
        }
        Invoke("ChangeRotation", rotationTime);
    }


    void Update()
    {
        randomTime = Random.Range(1,4);
        rotationTime = randomTime;
        transform.Rotate(new Vector3(0, rotationSpeed, 0 * Time.deltaTime));
        transform.position += transform.forward * movementSpeed * Time.deltaTime;

    }
}