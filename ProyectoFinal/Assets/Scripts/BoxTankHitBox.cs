using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTankHitBox : MonoBehaviour
{
    public BossTankController bossCont;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
  
    }
    //dentro de " " se colocala el nombre de el tag del distpara del jugador para que haga colicion 
    private void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Player" ) {

            bossCont.TakeHit();
            gameObject.SetActive(false);
        }

    }
}
