using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Menu;
    // public GameObject instruction;
    //public GameObject leaderboard;

    // public bool boardOn = false;
    // public bool isMenu = false;
    // public bool isPaused = false;
    // public bool isInstruction = false;

    // public void MenuFunction()
    // {
    //     menu.SetActive(true);
    //     // timer.SetActive(false);
    //     isMenu = true;
    //     Time.timeScale = 0f;
    //     Debug.Log("Menu is open");
    // }
    
    // public void Instructions()
    // {
    //     instruction.SetActive(true);
    //     isInstruction = true;

    //     pause.SetActive(false);
    //     menu.SetActive(false);
    //     leaderboard.SetActive(false);
    //     timer.SetActive(false);

    //     isPaused = false;
    //     isMenu = false;
    //     boardOn = false;

    //     Time.timeScale = 0f;
    //     Debug.Log("Instructions is open");
    // }

    public void Resume()
    {
        // pause.SetActive(false);
        // menu.SetActive(false);
        // leaderboard.SetActive(false);
        // instruction.SetActive(false);
        // timer.SetActive(true);

        // isPaused = false;
        // isMenu = false;
        // boardOn = false;
        // isInstruction = false;
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    // public void Start()
    // {
    //     MenuFunction();
    // }

    public void Play()
        {
            Resume();
            Debug.Log("play mode");
        }

        public void Quit()
        {
        #if UNITY_EDITOR
         // Application.Quit() does not work in the editor so
         // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
         UnityEditor.EditorApplication.isPlaying = false;
        #else
         Application.Quit();
        #endif
        }

        // public void Leaderboard()
        // {
        //     leaderboard.SetActive(true);
        //     pause.SetActive(false);
        //     menu.SetActive(false);
        //     instruction.SetActive(false);
        //     timer.SetActive(false);

        //     boardOn = true;
        //     isPaused = false;
        //     isMenu = false;
        //     isInstruction = false;

        //     Time.timeScale = 0f;
        //     Debug.Log("leaderboard");
        // }
}