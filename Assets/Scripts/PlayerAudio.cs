using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    PlayerMovement player;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlayerMovement>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
