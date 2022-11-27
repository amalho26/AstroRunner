using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public AudioSource audioSource;
    public bool startPlaying;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void starHit()
    {
        Debug.Log("Star hit");
    }
    public void starMiss()
    {
        Debug.Log("Star miss");
    }
}
