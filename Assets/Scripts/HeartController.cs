using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class HeartController : MonoBehaviour
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

    // bool starScore = false;
    

    void Start()
    {
      GC = FindObjectOfType<GameController>();
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
        Debug.Log("<3 Heart Collected <3");      
        if(col.gameObject.tag == player.tag){
          Debug.Log("<3 <3 <3 ******** Player Collected Heart ***** <3 <3 <3 ");
          audioSource.Play();
          GC.AdjustScore(20f);
          Destroy(gameObject);       
        }
    }


    void SendNote()
    {
        transform.DOMove(target.position, duration);
    }
}
