using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScriptExamen : MonoBehaviour
{
    public static ScriptExamen instance;

    public GameObject keepPersonaje;
    public GameObject [] newPersonas;



    public void pauseButton()
    {
        WantedScreen.instance.Mostrar2();

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void powerUpButton()
    {
        newPersonas = GameController.instance.personajes;

        for (int i = 0; i < (newPersonas.Length); i++)
        {
            //newPersonas.Length =newPersonas.Length / 2f;
            //newPersonas.SetActive

        }

    }

    public void KeepPersonaje()
    {
        keepPersonaje = WantedScreen.instance.personaje;

    }
}