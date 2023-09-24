using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tracker : MonoBehaviour{

    public int contador;
    public TMP_Text tmp;

    // Start is called before the first frame update

    void Start(){
        contador = 0;
        tmp.text = "0";        
    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Obstaculo"){           
            contador++; 
            tmp.text = contador.ToString();       
        }
    }

}
