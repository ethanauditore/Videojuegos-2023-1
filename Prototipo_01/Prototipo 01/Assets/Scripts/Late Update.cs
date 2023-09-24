using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateMove : MonoBehaviour{

    public float speed;

    // Update is called once per frame
    void LateUpdate(){
        this.transform.Translate(Time.deltaTime * speed,0f,0f);
    }
}

