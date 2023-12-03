using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool isHeal;
    private bool isCollected;

    private void OnTriggerEnter2D(Collider2D other) {

        if (isHeal) {
            if (PlayerHealtController.instance.vidas != PlayerHealtController.instance.maxVidas) {

                PlayerHealtController.instance.healPlayer();
                isCollected = true;
                Destroy(gameObject);
            }
        }
    }
}
