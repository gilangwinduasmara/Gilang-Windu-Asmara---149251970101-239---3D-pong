using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;

    private Rigidbody _rigidBody;

    public float movingSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        // _rigidBody.velocity = _rigidBody.velocity.normalized * movingSpeed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PaddleController>() != null)
        {
           
        }
    }
}
