using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _movement = new Vector3();
    public Transform Front;
    public Vector3 rotation;
    public float speed = 1;
    public float backSpeed = 1;
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
            MoveFor ();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            MoveBack();
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

    private void MoveFor()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void MoveBack()
    {
        transform.Translate(Vector3.back * backSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        Vector3 velocity = _movement * speed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(_rigidbody.position + velocity);
    }

}
