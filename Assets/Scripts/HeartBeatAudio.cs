using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeatAudio : MonoBehaviour
{
    private AudioSource Source;
    public GameObject EndGoal;
    
    

    // Start is called before the first frame update
    void Start()
    {
        Source = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "EndGoal")
        {
            Source.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "EndGoal")
        {
            Source.Stop();
        }
    }



}
