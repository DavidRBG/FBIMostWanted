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
    public float timing;
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

        if (timeOpen <= timer)
        {
            EnablePopUp();

            if (timing >= timeOpen)
            {
                popUp.SetActive(false);

            }
        }


        huntTime.text = timing.ToString();

        timeOpenText.text = timeOpen.ToString();
    }

    public void EnablePopUp()
    {
        timing += Time.deltaTime;
    }
}
