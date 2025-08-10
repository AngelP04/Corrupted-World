using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb2D;
    private Animator animator;
    private float Horizontal;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        if (Horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if(Horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        animator.SetBool("Moving", Horizontal != 0.0f);
    }

    private void FixedUpdate()
    {
        rb2D.velocity = new Vector2(Horizontal * Speed, rb2D.velocity.y);
    }
}
