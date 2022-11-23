using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   public float speed=1f;

void Update() 
{
transform.position = transform.position + (transform.forward * speed * Time.deltaTime);
}
}

