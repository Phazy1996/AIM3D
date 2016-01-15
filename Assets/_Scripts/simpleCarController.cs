using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[System.Serializable]
public class AxleInfo_3 {
	public WheelCollider leftWheel;
	public WheelCollider rightWheel;
	public bool motor; // is this wheel attached to motor?
	public bool steering; // does this wheel apply steer angle?
}
public class SimpleCarController : MonoBehaviour {
	public List<AxleInfo_3> axleInfos; // the information about each individualaxle
		public float maxMotorTorque; // maximum torque the motor can apply towheel
		public float maxSteeringAngle; // maximum steer angle the wheel can have
	public void FixedUpdate()
	{
		float motor = maxMotorTorque * Input.GetAxis("Vertical");
		float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
		foreach (AxleInfo_3 axleInfo in axleInfos) {
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