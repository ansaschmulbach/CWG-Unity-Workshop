using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class Movement : MonoBehaviour
{

    [SerializeField] [Range(0, 10)] private float speed;
    [SerializeField] private int _health;
    [SerializeField] private int StartHealth;
    private Transform _Transform;
    private Rigidbody2D _RigidBody2D;
    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        _Transform = GetComponent<Transform>();
        _RigidBody2D = GetComponent<Rigidbody2D>();
        _health = StartHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
        /** Version 1 code */
        // if (Input.GetKeyDown(KeyCode.W))
        // {
        //     _Transform.position += velocity;
        //     or
        //     _Transform.position += speed * velocity;
        // }

        velocity = Vector3.zero;
        velocity += Input.GetAxis("Horizontal") * Vector3.right;
        velocity += Input.GetAxis("Vertical") * Vector3.up;
        // _Transform.position += velocity * speed;
        _RigidBody2D.velocity = velocity * speed;
    }
    
    
}
