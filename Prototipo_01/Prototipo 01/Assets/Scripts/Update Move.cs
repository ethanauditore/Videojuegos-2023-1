using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMove : MonoBehaviour{

    public float speed, rotationSpeed;
    public float vm, hm;
    public GameObject screen;

    void Start(){
    }

    // Update is called once per frame
    void Update(){
        hm = Input.GetAxis("Horizontal");
        vm = Input.GetAxis("Vertical");
        this.transform.Translate(Time.deltaTime*speed*hm,0f,0f);
        //this.transform.Rotate(Vector3.up,rotationSpeed*Time.deltaTime*hm);
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Obstaculo"){
            screen.SetActive(true);
            this.gameObject.SetActive(false);            
        } 
    }
}

