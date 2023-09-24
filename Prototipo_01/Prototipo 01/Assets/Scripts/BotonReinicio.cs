using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio : MonoBehaviour{

    public void reiniciarJuego(){
        SceneManager.LoadScene(1);
    }
    public void iniciarJuego()
    {
        SceneManager.LoadScene(1);
    }
    public void iniciarMenu()
    {
        SceneManager.LoadScene(0);
    }
}
