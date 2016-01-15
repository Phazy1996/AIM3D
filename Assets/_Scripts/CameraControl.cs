using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	float rightTrigger = Input.GetAxis ("RightTrigger");
	float leftTrigger = Input.GetAxis ("LeftTrigger");
	[SerializeField]
	private Camera []cameras;
	private CarMovement carMove;
	
	// Use this for initialization
	void Start () {
		carMove = GetComponent<CarMovement>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	/*	if()
		{
			foreach(Camera cam in cameras){
				//cam.enabled = false;
				print(carMove.speed);
			}
		}
		/*if(leftTrigger > 0 || Input.GetKeyDown(KeyCode.S))
		{
			
		}*/
	}
}