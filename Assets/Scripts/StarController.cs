using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class StarController : MonoBehaviour
{

    public float duration = 3;
    public Transform target;
    private float timer;
    public float triggerTime;
    public bool hasStarted;
    public AudioSource audioSource;
    public bool startPlaying;
    public GameObject player;

    // Start is called before the first frame update
    // Update is called once per frame
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
          Debug.Log("Player hit");
            audioSource.Play();
            

        }
    }

    void SendNote()
    {
        transform.DOMove(target.position, duration);
    }
}
