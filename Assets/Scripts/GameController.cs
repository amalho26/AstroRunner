using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public AudioSource audioSource;
    public TextMeshProUGUI scoreText;
    public float score;

    void Start()
    {
        score = 0f;
        audioSource.Play();

    }

    void Update()
    {
        score += Time.deltaTime;
        Debug.Log(score);
        scoreText.text = score.ToString("0");
    }

    public void AdjustScore(float adjustment)
    {
        score += adjustment;
        Debug.Log("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Score: " + score);
    }
    
    public void Restart()
    {
        score = 0;
        Debug.Log("Game Restarted");
        scoreText.text = score.ToString("0");
    }
}
