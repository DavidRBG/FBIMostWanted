using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public GameObject[] personajes;
    public int iChar;

    public bool isPlaying = false;
    public int nivel = 1;
    public GameObject failScreen;
    public GameObject gotchaScreen;

    //public AudioSource sounds;
    //public AudioClip wrong;
    //public AudioClip right;


    public GameObject keepPersonaje;


    private void Start()
    {

    }
    void Awake()
    {
        if (GameController.instance == null)
        {
            GameController.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        RaycastPoint();
        if (nivel > 5)

        {
            nivel = 1;
            SceneManager.LoadScene(0);
        }
    }
    public GameObject RandomPersonaje()
    {
        iChar = Random.Range(0, personajes.Length);
        personajes[iChar].tag = "Player";
        return Instantiate(personajes[iChar]);
    }

    public GameObject RandomPersonas()
    {
        int num = Random.Range(0, personajes.Length);

        while (num == iChar)
        {
            num = Random.Range(0, personajes.Length);
        }
        personajes[num].tag = "Persona";

        return Instantiate(personajes[num]);
    }

    public void RellenarNivel()
    {
        GameObject buscado = Instantiate(personajes[iChar]);
        GameObject escondite = HidePoints.instance.RandomHidePoints();
        buscado.transform.parent = escondite.transform;
        buscado.transform.localPosition = Vector3.zero;
        buscado.transform.localScale = Vector3.one;
        buscado.transform.LookAt(Camera.main.transform);

        for (int i = 0; i < (nivel * 5 - 1); i++)
        {
            GameObject personas = RandomPersonas();
            GameObject escondites = HidePoints.instance.RandomHidePoints();
            personas.transform.parent = escondites.transform;
            personas.transform.localPosition = Vector3.zero;
            personas.transform.localScale = Vector3.one;
            personas.transform.LookAt(Camera.main.transform);
        }
    }

    public void RerellenarNivel()
    {
        HidePoints.instance.LimpiarHidePoints(iChar);
        RellenarNivel();
    }
    void Gotcha()
    {
        //Debug.Log("Encontrado"); 
        //sounds = gameObject.GetComponent<AudioSource>();
        //sounds.PlayOneShot(right);

        GameObject popUp = Instantiate(gotchaScreen);
        popUp.SetActive(true);
        personajes[iChar].tag = "Persona";
        nivel++;
        gotchaScreen.SetActive(true);
        isPlaying = false;
    }

    void Fail()
    {
        //Debug.Log("Perdiste");
        //sounds = gameObject.GetComponent<AudioSource>();
        //sounds.PlayOneShot(wrong);
        GameObject popUp = Instantiate(failScreen);
        popUp.SetActive(true);
        isPlaying = false;
    }


    public void RaycastPoint()
    {
        if (isPlaying == true)
        {
            if((Input.touchCount >=1 && Input.GetTouch(0).phase == TouchPhase.Ended) || (Input.GetMouseButtonUp(0)))
            {
                Vector3 pos = Input.mousePosition;
                if (Application.platform == RuntimePlatform.Android)
                {
                    pos = Input.GetTouch(0).position;
                }

                Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast(rayo, out hitInfo))
                {
                    if (hitInfo.transform.tag == "Player")
                    {
                        Gotcha();
                    }

                    if (hitInfo.transform.tag == "Persona")
                    {
                        Fail();
                    }
                }
            }
        }
    }

}
