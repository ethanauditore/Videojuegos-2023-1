﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public float waitToRespawn;

    private void Awake() { 
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnPlayer() {
        StartCoroutine(RespawnCo());
    }

    IEnumerator RespawnCo(){ 
        PlayerController.instance.gameObject.SetActive(false);

        yield return new WaitForSeconds(waitToRespawn);
        
        PlayerController.instance.gameObject.SetActive(true);
        PlayerController.instance.transform.position = CheckpointController.instance.spawnPoint;
        

    }
}
