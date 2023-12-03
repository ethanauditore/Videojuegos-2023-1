using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    [Header("Movimiento")]
    public float moveSpeed;

    [Header("Salto")]
    private bool canDoubleJump;
    public float jumpForce;

    [Header("Componentes")]
    public Rigidbody2D theRB;

    [Header("Animactor")]
    public Animator anim;
    private SpriteRenderer theSR;

    [Header("Grounded")]
    private bool isGrounded;
    public Transform groundCheckpoint;
    public LayerMask whatIsGroud;

    public float tiempoGolpe, fueerzaGolpe;
    private float contadorGolpe;

    private void Awake() { 
        instance = this;
    }
    void Start()
    {
        anim = GetComponent<Animator>();  
        theSR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (contadorGolpe <= 0)
        {
            theRB.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), theRB.velocity.y);
            // con esto nos dice si el jugador esta en el piso 
            isGrounded = Physics2D.OverlapCircle(groundCheckpoint.position, .2f, whatIsGroud);

            if (isGrounded)
            {
                canDoubleJump = true;
            }
            if (Input.GetButtonDown("Jump"))
            {
                if (isGrounded)
                {
                    theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
                }
                else
                {
                    if (canDoubleJump)
                    {
                        theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
                        canDoubleJump = false;
                    }
                }
            }

            //permite que la animacion del jugador rote cuando se mueve 
            if (theRB.velocity.x < 0)
            {
                theSR.flipX = true;
            }
            else if (theRB.velocity.x > 0)
            {
                theSR.flipX = false;
            }
        }
        else 
        { 
        contadorGolpe -= Time.deltaTime;
        }
      
        anim.SetFloat("moveSpeed",Mathf.Abs(theRB.velocity.x));
        anim.SetBool("isGrounded",isGrounded);
    }

    public void golpeRetroseso() {
        contadorGolpe = tiempoGolpe;
        theRB.velocity = new Vector2(0f, fueerzaGolpe);
    }
}
