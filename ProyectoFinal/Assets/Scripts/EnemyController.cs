using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float moveSpeed;

    public Transform lefPoint, rightPoint;

    private bool movingRight;

    private Rigidbody2D theRB;
    
    public float moveTime, waitTime;
    
    private float moveCount, waitCount;

    public SpriteRenderer theSR;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        lefPoint.parent = null;
        rightPoint.parent = null;
        movingRight = true;
        moveCount = moveTime;
     }

    // Update is called once per frame
    void Update()
    {
        if (moveCount > 0) {
            moveCount -= Time.deltaTime;
            if (movingRight)
            {
                theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);
                theSR.flipX = true;

                if (transform.position.x > rightPoint.position.x)
                {
                    movingRight = false;
                }
            }
            else
            {
                theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);
                theSR.flipX = false;
                if (transform.position.x < lefPoint.position.x)
                {
                    movingRight = true;
                }
            }
            if (moveCount <= 0)
            {
                waitCount = Random.Range(waitTime*.75f, waitTime * 1.25f);
            }

            anim.SetBool("isMoving",true);
        }
        else if (waitCount > 0)
        {
            waitCount -= Time.deltaTime;
            theRB.velocity = new Vector2(0f, theRB.velocity.y);
            if (waitCount <= 0)
            {
                moveCount = waitCount = Random.Range(moveTime * .75f, moveTime * 1.25f);
            }
            anim.SetBool("isMoving", false);
        }

        
    }
}
