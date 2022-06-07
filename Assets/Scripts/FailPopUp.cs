using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailPopUp : MonoBehaviour
{
    public float timer;
    public float closeTimer =3f;


    void Update()
    { 

        if (gameObject.activeSelf==true)
        {
            timer += Time.deltaTime;

            if (closeTimer <= timer)
            {
                gameObject.SetActive(false);

            }



        }
    }
}
