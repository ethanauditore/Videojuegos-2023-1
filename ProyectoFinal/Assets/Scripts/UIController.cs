using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public Image corazon1, corazon2, corazon3;

    public Sprite corazonCompleto, corazonVacio;
    private void Awake() { 
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealthDisplay() {
        switch (PlayerHealtController.instance.vidas) {
            case 3:
                corazon1.sprite = corazonCompleto;
                corazon2.sprite = corazonCompleto;
                corazon3.sprite = corazonCompleto;
                break;
            
            case 2:
                corazon1.sprite = corazonCompleto;
                corazon2.sprite = corazonCompleto;
                corazon3.sprite = corazonVacio;
                break;
            
            case 1:
                corazon1.sprite = corazonCompleto;
                corazon2.sprite = corazonVacio;
                corazon3.sprite = corazonVacio;
                break;

            case 0:
                corazon1.sprite = corazonVacio;
                corazon2.sprite = corazonVacio;
                corazon3.sprite = corazonVacio;
                break;

            default :
                corazon1.sprite = corazonVacio;
                corazon2.sprite = corazonVacio;
                corazon3.sprite = corazonVacio;
                break;

        }
    }
}
