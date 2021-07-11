using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountUpTimer : MonoBehaviour
{
    public Text counterText;

    public float seconds, minutes;

    public float timer;

   void Start()
    {
        counterText = GetComponent<Text>() as Text;
        minutes = 00;
        seconds = 00; 
    }

   void Update()
    {
        timer += Time.deltaTime;

        minutes = (int)(timer / 60f);
        seconds = (int)(timer % 60f);
        if (minutes >= 3 && seconds >= 1)
        {
            SceneManager.LoadScene("LoseScene");
        } else
        {
            counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
    }
}
