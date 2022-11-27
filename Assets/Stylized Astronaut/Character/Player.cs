using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

		public float speed = 600.0f;
		private bool right = false;
		private bool left = false;
		float centerRight = 6f;
		float centerLeft = -6f;
		float center = 0f;
		float checkDistance = 0.001f;
		float movementSpeed = 10f;
		float targetPosition;
		

		void Start () {
			
		}

		void Update (){
			transform.position = transform.position + (transform.forward * speed * Time.deltaTime);
			//Debug.Log(transform.position.x);
			

			if(Input.GetKey(KeyCode.RightArrow) && transform.position.x < 4.5){
				right = true;
				targetPosition = transform.position.x + 2.5f;
				Debug.Log("Right");
			
			}else if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -4.5){
			left = true;
			
			targetPosition = transform.position.x - 2.5f;
			}				

			if(right)
			{
				left = false;
				
				
				
				Vector3 newPosition = new Vector3(targetPosition, transform.position.y, transform.position.z);
				
				if (Mathf.Abs(targetPosition - transform.position.x) > checkDistance)    
				{
					transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementSpeed);
				} else{
					right = false;
				}
			}

			if(left)
			{
				right = false;
				
				
				
				
				Vector3 newPosition = new Vector3(targetPosition, transform.position.y, transform.position.z);
				
				if (Mathf.Abs(targetPosition - transform.position.x) > checkDistance)    
				{
					transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementSpeed);
				} else{
					left = false;
				}
			}
			
		}
}
