using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealtController : MonoBehaviour
{
    public static PlayerHealtController instance;
    public int vidas, maxVidas;

    private float damageCounter;
    public float damageLength;

    private SpriteRenderer theSR;

    public GameObject deadEffect;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        vidas = maxVidas;
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (damageCounter > 0) { 
            damageCounter -= Time.deltaTime;
            if (damageCounter <= 0) {
                theSR.color = new Color(theSR.color.r,theSR.color.g,theSR.color.b,1f) ;
            }
        }
    }

    public void damagePlayer()
    {
        if (damageCounter <= 0){

        }
        else { 
        }
        vidas--;
        PlayerController.instance.anim.SetTrigger("Golpe");
        if (vidas <= 0)
        {
            vidas = 0;
            Instantiate(deadEffect,PlayerController.instance.transform.position, PlayerController.instance.transform.rotation);
            LevelManager.instance.RespawnPlayer();
        }
        else
        {
            damageCounter = damageLength;
            theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, .5f);
            PlayerController.instance.golpeRetroseso();
        }
        UIController.instance.UpdateHealthDisplay();

    }

    public void damagePlayerHunter()
    {
        vidas = vidas - 2;
        if (vidas <= 0)
        {
            vidas = 0;
            Instantiate(deadEffect, PlayerController.instance.transform.position, PlayerController.instance.transform.rotation);
            LevelManager.instance.RespawnPlayer();
        }
        else
        {
            damageCounter = damageLength;
            theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, .5f);
            PlayerController.instance.golpeRetroseso();
        }
        UIController.instance.UpdateHealthDisplay();
    }

    public void damagePlayerDead()
    {
        vidas = vidas - 3;
        if (vidas <= 0)
        {
            vidas = 0;
            Instantiate(deadEffect, PlayerController.instance.transform.position, PlayerController.instance.transform.rotation);
            LevelManager.instance.RespawnPlayer();
        }
        else
        {
            damageCounter = damageLength;
            theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, .5f);
            PlayerController.instance.golpeRetroseso();
        }
        UIController.instance.UpdateHealthDisplay();
    }


    public void healPlayer() {
        vidas = maxVidas;

        UIController.instance.UpdateHealthDisplay();
    }

}
