using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{

    public float tempo;
    public bool hasStarted;

    // Start is called before the first frame update
    void Start()
    {
        tempo = tempo/30f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                hasStarted = true;
            }
        }
        else
        {
            transform.position -= new Vector3(0, 0, tempo * Time.deltaTime);
        }
    }
}
