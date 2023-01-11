using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManagement : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Start");
    }
    
    public void QuitGame()
    {
        Application.Quit();
        
    }
    public void Again()
    {
        SceneManager.LoadScene("Start");
        
    }
    
}
