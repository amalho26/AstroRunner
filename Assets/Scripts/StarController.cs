using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class StarController : MonoBehaviour
{

    // public GameController GC ;
    public GameController GC;
    public float duration = 3;
    public Transform target;
    private float timer;
    public float triggerTime;
    public bool hasStarted;
    public AudioSource audioSource;
    public bool startPlaying;
    public GameObject player;

    bool starScore = false;
    

    void Start()
    {
    }
    void Update()
    {
      timer += Time.deltaTime;
      if(timer>=triggerTime-duration)
      {
        SendNote();
      }


    }
    void OnTriggerEnter(Collider col){
        Debug.Log("Star hit");      
        if(col.gameObject.tag == player.tag){
          Debug.Log("************************* Player hit *************************");
          audioSource.Play();
          GC.AdjustScore(100f);         
        }
    }


    void SendNote()
    {
        transform.DOMove(target.position, duration);
    }
}
