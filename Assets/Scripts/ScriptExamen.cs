using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScriptExamen : MonoBehaviour
{
    public GameObject keepPersonaje;
    public GameObject [] newPersonas;



    public void pauseButton()
    {
        //WantedScreen.instance.pantallaBuscar.SetActive(true);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        keepPersonaje = WantedScreen.instance.personaje;

    }

    public void powerUpButton()
    {
        //newPersonas = GameController.instance.personajes;


        //for (int i = 0; i < newPersonas.Length; i++)
        //{
        //    newPersonas.Length = newPersonas.Length / 2f;

        //}


    }
}