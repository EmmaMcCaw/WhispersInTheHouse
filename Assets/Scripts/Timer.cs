using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 180f;
    float startingTime = 00f;


    [SerializeField] Text countdownText;
    void Start()

    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        }


    }
}
