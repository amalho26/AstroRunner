using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pause;
    public AudioSource song; 
    public GameObject score;
    public GameManager GM;
    public bool isPaused = false;


    public void PauseFunction()
    {
        song.Pause();
        pause.SetActive(true);
        score.SetActive(false);
        isPaused = true;
        Time.timeScale = 0f;
        Debug.Log("Game is paused");
    }


    public void Play()
    {
        song.Play();
        pause.SetActive(false);
        score.SetActive(true);
        isPaused = false;
        Debug.Log("Game is resumed");
        Time.timeScale = 1f;
    }
    public void Quit()

        {
        GM.Restart();
        Debug.Log("Game is quit");
        #if UNITY_EDITOR
         // Application.Quit() does not work in the editor so
         // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
         UnityEditor.EditorApplication.isPlaying = false;
        #else
         Application.Quit();
        #endif
        }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            PauseFunction();
            Debug.Log("Pause Game");
        }
    }
}