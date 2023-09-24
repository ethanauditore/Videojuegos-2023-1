using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminaMontana : MonoBehaviour{

   public GameObject track;   

   private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            Destroy(track, 1.5f);        
        }
   }
}

