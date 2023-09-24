using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMontana : MonoBehaviour{

    public GameObject track;
    public Transform spawn;
    public Transform entorno;
    

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            GameObject aux = Instantiate(track, spawn.position, spawn.rotation);
            aux.transform.SetParent(entorno);
        }
    }
}

