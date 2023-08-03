using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class DoodleJumpPlayer : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float _moveSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _moveSpeed = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        Vector2 velocity = _rb.velocity;
        velocity.x = _moveSpeed;
        _rb.velocity = velocity;
    }
}
