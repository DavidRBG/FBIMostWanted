using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerPopUp : MonoBehaviour
{
    public static TimerPopUp instance;

    public GameObject wantedScreen;
    public GameObject timerScreen;
    public TextMeshProUGUI labelSearchTimer;
    private bool isWantedScreen;
    public float searchTimer;


    void Awake()
    {
        if (TimerPopUp.instance == null)
        {
            TimerPopUp.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    void Update()
    {
        if (WantedScreen.instance.timer <= 0)
        {
            timerScreen.SetActive(true);
            searchTimer += Time.deltaTime;
            labelSearchTimer.text = searchTimer.ToString("f0");

        }

    }
}
