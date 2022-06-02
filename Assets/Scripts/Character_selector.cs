using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_selector : MonoBehaviour
{
    public int indicepersonajeactivo;
    private GameObject personajeactivo;

    void OnEnable()
    { // seleccion de un personaje random /= wally, nos servirá para los escondites.
        indicepersonajeactivo = Random.Range(0, 29);
        if (indicepersonajeactivo == seleccion_personaje.instance.indicewally)
        {
            if (indicepersonajeactivo < 29)
            {
                indicepersonajeactivo++;
            }
            else
            {
                indicepersonajeactivo--;
            }
        }
        personajeactivo = gameObject.transform.GetChild(indicepersonajeactivo).gameObject;
        personajeactivo.SetActive(true);
        personajeactivo.transform.localScale = new Vector3(0.4f,0.4f,0.4f) ;
        Debug.Log("activo" + personajeactivo);
    }

    private void OnDisable()
    {
        personajeactivo.SetActive(false);
    }
}
