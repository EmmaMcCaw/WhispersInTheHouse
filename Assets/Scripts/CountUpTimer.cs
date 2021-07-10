using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountUpTimer : MonoBehaviour
{
    public Text counterText;

    public float seconds, minutes;

   void Start()
    {
        counterText = GetComponent<Text>() as Text;
    }

   void Update()
    {
        minutes = (int)(Time.time / 60f);
        seconds = (int)(Time.time % 60f);
        if (minutes >= 3 && seconds >= 1)
        {
            SceneManager.LoadScene("LoseScene");
        } else
        {
            counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
    }
}
