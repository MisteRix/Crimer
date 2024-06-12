using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame_Move : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D rb;
    private Vector2 direction;
    private Animator _anim;

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

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            _anim.SetBool("isRun", true);
        }
        else
        {
            _anim.SetBool("isRun", false);
        }
    }


    private void Move()
    {
        rb.MovePosition(rb.position + direction * _speed * Time.fixedDeltaTime);

    }



}