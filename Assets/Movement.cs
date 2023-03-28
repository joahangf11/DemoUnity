using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocidadX;
    public float velocidadY;

    private Rigidbody2D rigidBody;

    private Animator anim;

    private SpriteRenderer SpriteRenderer;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(movHorizontal * velocidadX, rigidBody.velocity.y);

        float movVertical = Input.GetAxis("Jump");      // [0, 1]
        if (movVertical > 0)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * velocidadY);
        }

        anim.SetFloat("Velocidad", Mathf.Abs(rigidBody.velocity.x));
        anim.SetBool("In_ground", CambioAnimación.In_ground);

        if (rigidBody.velocity.x > 0.1)
        {
            SpriteRenderer.flipX = false;
        }
        else if (rigidBody.velocity.x < -0.1)
        {
            SpriteRenderer.flipX = true;
        }
    }
}
