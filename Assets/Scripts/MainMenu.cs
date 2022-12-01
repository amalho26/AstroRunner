using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public GameObject Menu;
 
    public void Resume()
    {
  
        SceneManager.LoadScene("GameMode");
        Time.timeScale = 1f;
    }

    public void Play()
        {
            Resume();
            Debug.Log("play mode");
        }

        public void Quit()
        {
            
        #if UNITY_EDITOR
   
         UnityEditor.EditorApplication.isPlaying = false;
        #else
         Application.Quit();
        #endif
        }
}