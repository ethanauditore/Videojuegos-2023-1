using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateMove : MonoBehaviour{

    public float speed;

    // Update is called once per frame
    void FixedUpdate(){
        this.transform.Translate(0f,0f,Time.deltaTime * speed);
    }
}
