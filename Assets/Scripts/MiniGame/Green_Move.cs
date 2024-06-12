using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Move : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private float _speed;
    private int i;
    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, _speed * Time.fixedDeltaTime);
        if (Vector2.Distance(transform.position, points[i].position) < 0.2f)
        {
            if (i > 0)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
        }
    }
}
