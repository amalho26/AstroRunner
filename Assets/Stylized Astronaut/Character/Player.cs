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
		int randomControl = 2;
		//float targetPosition;
		public GameObject Lstar, Rstar, Mstar;
		public GameObject Lship, Rship, Mship;

		

		void Start () {
			StartCoroutine(Wait2());
		}

		void Update (){
			//SpawnStars();

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
		void SpawnStars(){
			int random;
			do{
				random = Random.Range(1, 4);
			}while(System.Math.Abs(random - randomControl) != 1);
			
			if(random == 1){
				Instantiate(Lstar, new Vector3(-5f,1f,70f), Quaternion.identity);
				randomControl = 1;
			}else if(random == 2){
				Instantiate(Mstar, new Vector3(0f,1f,70f), Quaternion.identity);
				randomControl = 2;
			}else if(random == 3){
				Instantiate(Rstar, new Vector3(5f,1f,70f), Quaternion.identity);
				randomControl = 3;
			}
			StartCoroutine(Wait());
		}
		void SpawnShips(){
			int random;
				random = Random.Range(1, 4);
			
			if(random == 1){
				Instantiate(Lship, new Vector3(-5f,3f,62f), Quaternion.identity);
			}else if(random == 2){
				Instantiate(Mship, new Vector3(0f,3f,62f), Quaternion.identity);
			}else if(random == 3){
				Instantiate(Rship, new Vector3(5f,3f,62f), Quaternion.identity);
			}
			StartCoroutine(Wait3());
		}
		IEnumerator Wait()
		{
			yield return new WaitForSeconds(0.976f);
			SpawnStars();
			SpawnShips();
			
		}
		
		IEnumerator Wait2()
		{
			yield return new WaitForSeconds(3f);
			SpawnStars();
			SpawnShips();
			
		}

		IEnumerator Wait3()
		{
			yield return new WaitForSeconds(2f);
			
		}

}
