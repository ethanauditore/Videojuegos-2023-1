using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour{

    public Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start(){
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        float hm = Input.GetAxis("Horizontal");
        float vm = Input.GetAxis("Vertical");
        Vector3 mov = new Vector3(hm, 0, vm);
        rb.AddForce(mov*speed);
    }
}

