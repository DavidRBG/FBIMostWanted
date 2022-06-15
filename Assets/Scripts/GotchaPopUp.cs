using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GotchaPopUp : MonoBehaviour
{
    public TextMeshProUGUI thisLevelScore;
    public TextMeshProUGUI totalScore;


    public void ClickOnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void ClickOnNextLevel()
    {
        SceneManager.LoadScene(Random.Range(1, 3));

    }
}
