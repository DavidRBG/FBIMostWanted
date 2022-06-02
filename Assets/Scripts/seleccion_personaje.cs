using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seleccion_personaje : MonoBehaviour
{
    public static seleccion_personaje instance;
    public int indicewally;

    void OnEnable()
    {


        indicewally = Random.Range(0, 29);
        if (seleccion_personaje.instance == null)
        {
            instance = this;
            if (transform.childCount > 0f)
            {



            }
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            gameObject.SetActive(false);
        }

        gameObject.transform.GetChild(indicewally).gameObject.SetActive(true);
        gameObject.transform.GetChild(indicewally).gameObject.transform.position = gameObject.transform.GetChild(indicewally).gameObject.transform.parent.transform.position;

    }
}
