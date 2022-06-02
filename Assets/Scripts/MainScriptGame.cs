using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScriptGame : MonoBehaviour
{
    public string nameScene1;
    public string nameScene2;

    public GameObject[] gameCharacters;
    public int iChar;

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void PressButton()
    {
        SceneManager.LoadScene(Random.Range(1,3));

    }

}
