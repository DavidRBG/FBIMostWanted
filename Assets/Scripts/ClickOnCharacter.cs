using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnCharacter : MonoBehaviour
{

    public bool IsWally = false;
    AudioSource sonidos;

    public AudioClip wrong;
    public AudioClip right;
    public GameObject WinPopUp;

    public float timer;
    public float fail =0f;
    public float tiempoTranscurrido;
    //public float addingAllThePoints;

    public generador_position_character posicionesrellenar;


    void Update()
    {
        timer += Time.deltaTime;
        tiempoTranscurrido = timer + fail;
        //addingAllThePoints = posicionesrellenar.ToString() * 100f / tiempoTranscurrido;
    }

    private void OnMouseDown()
    {
        if (IsWally)
        {
            sonidos = gameObject.GetComponent<AudioSource>() ;
            sonidos.PlayOneShot(right);
            WinPopUp.SetActive(true);
        }

        if (!IsWally)
        {
            sonidos = gameObject.GetComponent<AudioSource>();
            sonidos.PlayOneShot(wrong);
            fail += 10f;
        }
    }

}