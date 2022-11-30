using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public AudioSource audioSource;
    public bool startPlaying;
    public TextMeshProUGUI scoreText;
    float score ;
    float boost ;
    // float timeElapsed=0;
    // Start is called before the first frame update
    void Start()
    {   
        score = 0.1f;
        boost = 0;
        audioSource.Play();
        scoreText.text = score.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        GetScore();
        scoreText.text = score.ToString("0");
        // boost = 0;
    }
    public void GetScore()
    {
        score += (0.1f + boost);   
    }

    public void BoostScore(){
        boost = 100f;
        Debug.Log("Star Collected Score: "+score);
    }
    public void Deboost(){
        boost = 0;
        Debug.Log("Star DEBOOSTED Score: "+score);
    }


public void Restart(){
    score = 0;
    Debug.Log("Game Restarted");
    scoreText.text = score.ToString("0");
}
   

    // public void DecScore()
    // {
    //     timeElapsed-=1;
    //     Debug.Log("Star miss");
    // }
}
