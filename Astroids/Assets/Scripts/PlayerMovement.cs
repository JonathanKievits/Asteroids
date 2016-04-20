using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _movement = new Vector3();

    public Vector3 rotation;
    public float speed = 1;
    public float rotationSpeed;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = 0;
        float z = 0;
        if (Input.GetKey(KeyCode.W))
        {
            z += 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            z += -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x += -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            x += 1;
        }else if (Input.GetKeyUp(KeyCode.W))
        {
            z += 3;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            z += -3;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            x += -3;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            x += 3;
        }
        _movement = new Vector3(x, 0f, z);
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotationSpeed = -7;
        }else if (Input.GetKey(KeyCode.RightArrow))
        {
            rotationSpeed = 7;
        }
        else
        {
            rotationSpeed = 0;
        }
    }

    void FixedUpdate()
    {
        Vector3 velocity = _movement * speed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(_rigidbody.position + velocity);
    }

}
