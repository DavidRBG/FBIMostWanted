using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsSaveData : MonoBehaviour
{
    public static StatsSaveData instance;

    public float totalPoints;
    public GameObject currentLevel;
    public GameObject currentScenario;


    // Start is called before the first frame update
    void Start()
    {
        if (StatsSaveData.instance == null)
        {
            StatsSaveData.instance = this;
        }

        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
