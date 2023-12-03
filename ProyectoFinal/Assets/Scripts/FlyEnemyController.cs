using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemyController : MonoBehaviour
{

    [SerializeField] private float speedMove;

    [SerializeField] private Transform[] pointsMove;

    [SerializeField] private float distanceMin;

    private int randomNum;

    private SpriteRenderer spriteRenderer;


    private void Start() {
        randomNum = Random.Range(0,pointsMove.Length);
        spriteRenderer = GetComponent<SpriteRenderer>();
        Girar();
    }
    private void Update() {
        transform.position = Vector2.MoveTowards(transform.position, pointsMove[randomNum].position,speedMove * Time.deltaTime );

        if (Vector2.Distance(transform.position, pointsMove[randomNum].position) < distanceMin) {
            randomNum = Random.Range(0,pointsMove.Length);
            Girar();
        }
    }

    private void Girar() {

        if (transform.position.x > pointsMove[randomNum].position.x)
        {
            spriteRenderer.flipX = false;

        }
        else { 
        spriteRenderer.flipX = true;
        }
    }
}
