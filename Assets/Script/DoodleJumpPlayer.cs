using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class DoodleJumpPlayer : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float _moveSpeed = 10.0f;
    float _move;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _move = Input.GetAxis("Horizontal") * _moveSpeed;
    }

    void FixedUpdate()
    {
        Vector2 velocity = _rb.velocity;
        velocity.x = _move;
        _rb.velocity = velocity;
    }
}
