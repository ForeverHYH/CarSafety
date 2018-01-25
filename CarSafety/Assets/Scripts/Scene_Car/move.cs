using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    private float speed;
    private float rotation;
	// Use this for initialization
	void Start () {
        speed = 10f;
        rotation = 100f;
	}
	
	// Update is called once per frame
	void Update () {
        float accelerator = Input.GetAxis("Accelerator");
        float handle = Input.GetAxis("HANDLE");

        this.transform.position += this.transform.forward * speed * accelerator * Time.deltaTime;
        this.transform.Rotate(Vector3.up * handle);

    }
}
