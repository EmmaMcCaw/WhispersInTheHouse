using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        Debug.Log("PLAY GAME");

        SceneManager.LoadScene("LayoutScene");
    }

    public void ReturnToMenu()
    {
        Debug.Log("RETURN TO MENU");

        SceneManager.LoadScene("MainMenu");

    }

    
}