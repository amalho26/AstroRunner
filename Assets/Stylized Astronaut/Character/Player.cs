using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

		public float speed = 600.0f;
		Vector3 targetPositionRight = new Vector3(5f,0f,42f);
		Vector3 targetPositionLeft = new Vector3(-5f,0f,42f);
		Vector3 targetPositionMiddle = new Vector3(0f,0f,42f);
		Vector3 newPosition;
		private bool right = false;
		private bool left = false;
		float checkDistance = 0.001f;
		float movementSpeed = 8f;
		//float targetPosition;
		

		void Start () {
		}

		void Update (){

			if(Input.GetKey(KeyCode.RightArrow)){
				right = true;
				if(transform.position.x<-1){
					newPosition = targetPositionMiddle;
				}else{
					newPosition = targetPositionRight;
				}
			}else if(Input.GetKey(KeyCode.LeftArrow)){
				left = true;
				if(transform.position.x>1){
					newPosition = targetPositionMiddle;
				}else{
					newPosition = targetPositionLeft;
				}
			}				

			if(right)
			{
				left = false;
				
				if (Mathf.Abs(newPosition.x - transform.position.x) > checkDistance)    
				{
					transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementSpeed);
				}
			}

			if(left)
			{
				right = false;
				
				if (Mathf.Abs(newPosition.x - transform.position.x) > checkDistance)    
				{
					transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementSpeed);
				}
			}
			
		}

}
