using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WantedTimer : MonoBehaviour
{
    public float timeOpen;
    public Text timeOpenText;
    public float timer;
    public GameObject screen;
    public Text huntTime;
    public GameObject characterShow;

    public GameObject popUp;
    public GameObject spawnPosition;

    MainScriptGame MainScriptGame ;

    // Start is called before the first frame update
    void Start()
    {
        //spawnPosition = MainScriptGame.selectedCharacter;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeOpen)
            {
                popUp.SetActive(false);

            }




        timeOpenText.text = timeOpen.ToString();
    }
}
