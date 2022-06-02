using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnCharacter : MonoBehaviour
{

    public bool IsWally = false;
    AudioSource sonidos;

    public AudioClip wrong;
    public AudioClip right;
    //public GameObject WinPopUp;



    private void OnMouseDown()
    {
        if (IsWally)
        {
            sonidos=gameObject.GetComponent<AudioSource>() ;
            //Debug.Log("si es Wally");
            sonidos.PlayOneShot(right);

        }

        if (!IsWally)
        {
            sonidos = gameObject.GetComponent<AudioSource>();
            //Debug.Log("no es Wally es: " + gameObject.name);
            sonidos.PlayOneShot(wrong);
        }
    }

}
