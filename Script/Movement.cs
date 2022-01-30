using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed, jumpDistance;
    Rigidbody2D rb;
    bool isGround = false;
    [SerializeField] GameObject health;
    HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        healthBar = health.GetComponent<HealthBar>();
    }

    // Update is called once per frame
    void Update()
    {
        ToMove();
    }
    void ToMove()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(jumpDistance , 0f, 500f));
            isGround = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(Mathf.Clamp(-speed, -500f, 0f), rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(Mathf.Clamp(speed , 0f, 500f), rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
        if (collision.gameObject.CompareTag("Enemy2"))
        {
            Destroy(this.gameObject);
        }
    }
    
}
