using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryTrigger : MonoBehaviour
{
    public Text counterText;

    public float seconds, minutes;

    public float timer;

    public GameObject EndGoal; 

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<Text>() as Text;
        minutes = 00;
        seconds = 00;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        minutes = (int)(timer / 60f);
        seconds = (int)(timer % 60f);

        //if(OnTriggerEnter2D.gameObject.name == "EndGoal")
        //{
            //SceneManager.LoadScene("VictoryScene");
      //  }
        //else
       // {
           // counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
       // }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
       // SceneManager.LoadScene("VictoryScene");
    //}
}
