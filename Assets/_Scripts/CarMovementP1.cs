using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[System.Serializable]
public class AxleInfo_7 {
	public WheelCollider leftWheel;
	public WheelCollider rightWheel;
	public bool motor; // is this wheel attached to motor?
	public bool steering; // does this wheel apply steer angle?
}

public class CarMovementP1 : MonoBehaviour {
	public AudioSource CarSiren;
	public List<AxleInfo_7> axleInfos; // the information about each individual axle
		public float maxMotorTorque; // maximum torque the motor can apply to wheel
		public float maxSteeringAngle; // maximum steer angle the wheel can have


	public void FixedUpdate()
	{
		float motor = maxMotorTorque * Input.GetAxis("Vertical");
		float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
		foreach (AxleInfo_7 axleInfo in axleInfos) {
			if (axleInfo.steering) {
				axleInfo.leftWheel.steerAngle = steering;
				axleInfo.rightWheel.steerAngle = steering;
			}
			if (axleInfo.motor) {
				axleInfo.leftWheel.motorTorque = motor;
				axleInfo.rightWheel.motorTorque = motor;
			}
		}
	}
}