using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

	[SerializeField]
	private float speed = 10f;
	[SerializeField]
	private float maxSpeed = 10f;
	[SerializeField]
	private float steer = 1f;
	[SerializeField]
	private float accelerate = 10f;
	[SerializeField]
	private float brake = 1f;
	[SerializeField]
	private bool reverse;

	Rigidbody rb;
	float xPosStick;
	float yPosStick;

	void Awake()
	{
		rb = GetComponent <Rigidbody> ();
	}
	void Update()
	{
		xPosStick = Input.GetAxis ("Horizontal");
		yPosStick = Input.GetAxis ("Vertical");
	}
	// Update is called once per frame
	void FixedUpdate () {
		Movement ();
		Steering ();
		
	}
	
	//Moving car forwards or reverse (later left and right trigger)
	void Movement (){
		Rigidbody rb = GetComponent <Rigidbody>();
		float rightTrigger = Input.GetAxis ("RightTrigger");
		float leftTrigger = Input.GetAxis ("LeftTrigger");
		//Debug.Log(rb.velocity);
		print(rb.velocity);
		//Keycodes are for dev use only!
		if(rightTrigger > 0 || Input.GetKeyDown(KeyCode.W))
		{
			
			//rb.velocity = new Vector3(0,0,(speed*accelerate));
			rb.AddForce(transform.forward*(accelerate*speed));


			//Right trigger
		}
		if(leftTrigger > 0 || Input.GetKeyDown(KeyCode.S))
		{
			//LeftTrigger
				rb.AddForce(transform.forward*(-accelerate*speed));

				
			//Debug.Log("Left trigger works");
		}
		/*		if(rightTrigger == 0 && leftTrigger == 0)
		{
			//Nothing is pressed
		}
		else if(rightTrigger > 0 && leftTrigger > 0)
		{
			//Both are pressed
		}   */
		
		
	}
	
	//Steering car left or right with A and D Key (later left and right input of Left joystick)
	void Steering (){
		string currentAxis;
		float axisInput;

			Quaternion rotation = Quaternion.Euler(new Vector3(0, xPosStick, 0) * steer );
			rb.MoveRotation(rotation * rb.rotation);
	}
}
