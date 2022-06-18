using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePoints : MonoBehaviour
{

    public static HidePoints instance;

    public GameObject[] hidePoints;


    void Awake()
    {
        if (HidePoints.instance == null)
        {
            HidePoints.instance = this;
        }
        else
        {
            Destroy(this);
        }
    }


    void Rellenar()
    {
        
        //hidePoints = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            hidePoints[i] = transform.GetChild(i).gameObject;
        }
    }

    public GameObject RandomHidePoints()
    {
        int pos = Random.Range(0, hidePoints.Length);

        while (hidePoints[pos].transform.childCount != 0)
            {
                pos = Random.Range(0, hidePoints.Length);
            }
        return hidePoints[pos];




    }

    public void LimpiarHidePoints(int x)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).childCount !=0)
            {

                GameObject destruir = transform.GetChild(i).GetChild(0).gameObject;
                Destroy(destruir);
                Debug.Log("Sirve");

            }


        }

    }
}
