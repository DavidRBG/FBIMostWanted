using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WantedScreen : MonoBehaviour
{

    public static WantedScreen instance;

    public TextMeshProUGUI contador;
    public float timer = 5f;
    public GameObject pantallaBuscar;
    public GameObject pantallaBuscar2;

    public GameObject spawnPoint;
    public GameObject personaje;
    private bool  primeraVez = true;   



    void Awake()
    {
        if (WantedScreen.instance == null)
        {
            WantedScreen.instance = this;
            Mostrar();
        }

        else
        {
            Destroy(this);
        }
        timer = 5f;
    }

    void Update()
    {
        if (timer <= 0)
        {
            Cerrar();
        }

        timer -= Time.deltaTime;
        contador.text = timer.ToString("f0");
    }

    public void Mostrar()
    {
        pantallaBuscar.SetActive(true);
        GameController.instance.isPlaying = false;
        SetWantedCharacter();
    }

    public void Cerrar()
    {
        if (primeraVez)
        {
            GameController.instance.RellenarNivel();
            primeraVez = false;
        }
        else
        {
            GameController.instance.RerellenarNivel();
        }

        GameController.instance.isPlaying = true;
        timer = 5;
        pantallaBuscar.SetActive(false);
        

    }

    public void SetWantedCharacter()
    {
        personaje = GameController.instance.RandomPersonaje();
        personaje.transform.parent = spawnPoint.transform;
        personaje.transform.position = spawnPoint.transform.position;
        personaje.transform.localScale = Vector3.one * 300;
        personaje.transform.rotation = spawnPoint.transform.rotation;
    }

    public void Mostrar2()
    {
        pantallaBuscar.SetActive(true);
        GameController.instance.isPlaying = false;

    }
}
