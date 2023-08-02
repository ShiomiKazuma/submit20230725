using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodleJumpGround : MonoBehaviour
{
    [SerializeField] float _jumpPower = 10f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //ã‚©‚ç‚ÌÕ“Ë‚¾‚¯ˆ—‚ğs‚¤
        if(collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = _jumpPower;
                rb.velocity = velocity;
            }
        }
        
    }
}
