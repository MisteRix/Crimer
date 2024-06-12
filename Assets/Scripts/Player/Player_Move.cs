using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Animator _anim;
    private Rigidbody2D rb;
    private Vector2 direction;
    private bool facingRight;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }


    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
        Move();

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A))
        {
            _anim.SetBool("isRun", true);
        }
        else
        {
            _anim.SetBool("isRun", false);
        }
    }

    private void FixedUpdate()
    {
        if (facingRight == false && direction.x < 0)
        {
            Flip();
        }
        else if (facingRight == true && direction.x > 0)
        {
            Flip();
        }
    }

    private void Move()
    {
        rb.MovePosition(rb.position + direction * _speed * Time.fixedDeltaTime);

    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }


}
