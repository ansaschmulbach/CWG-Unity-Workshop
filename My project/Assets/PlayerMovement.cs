using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] [Range(0, 10f)] private float speed;
    private Transform _Transform;
    private Rigidbody2D _rigidBody2D;
    private Vector3 _velocity;

    // Start is called before the first frame update
    void Start()
    {
        _Transform = GetComponent<Transform>();
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _velocity = Input.GetAxis("Horizontal") * Vector3.right;
        _velocity += Input.GetAxis("Vertical") * Vector3.up;
        _rigidBody2D.velocity = _velocity * speed;

    }

}
