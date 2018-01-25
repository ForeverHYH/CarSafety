using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicleController : MonoBehaviour {

	public float moveSpeed = 5;
	public float rotateSpeed = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.up.y > 0 && gameObject.transform.up.y <= 10) {
			if (Input.GetKey (KeyCode.W)) {
				if (moveSpeed <= 30) {
					moveSpeed = moveSpeed + 10 * Time.deltaTime;
				}
//				gameObject.transform.Translate (Vector3.forward*Time.deltaTime*moveSpeed);
				//moveforward

			}
			else if (Input.GetKey (KeyCode.S)) {
				if (moveSpeed >= -5) {
					moveSpeed -= 5 * Time.deltaTime;
				}
//				gameObject.transform.Translate (Vector3.forward*Time.deltaTime*moveSpeed);
				//movebackward
			}
			if (Input.GetKey (KeyCode.Space)) {
				if (moveSpeed >= 0) {
					moveSpeed -= 10 * Time.deltaTime;
				} else {
					moveSpeed = 0;
				}
			}
			if (moveSpeed > 0) {
				if (Input.GetKey (KeyCode.A)) {
					rotateSpeed -= 10 * Time.deltaTime;  //rotate speed 可以和handle绑定，再乘上一个系数
				} else if (Input.GetKey (KeyCode.D)) {
					rotateSpeed += 10 * Time.deltaTime;
				}
				moveSpeed -= 5 * Time.deltaTime;
			} else {
				if (Input.GetKey (KeyCode.A)) {
					rotateSpeed += 10 * Time.deltaTime;
				} else if (Input.GetKey (KeyCode.D)) {
					rotateSpeed -= 10 * Time.deltaTime;
				}
			}
			gameObject.transform.Translate (Vector3.forward*Time.deltaTime*moveSpeed);
			gameObject.transform.Rotate (Vector3.up * Time.deltaTime * rotateSpeed);
		}
	}
}
