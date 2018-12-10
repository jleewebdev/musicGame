using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    [SerializeField] public float fallSpeed;
    [SerializeField] float rotationSpeed;
    Quaternion rotationPosition;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        float randomX = Random.RandomRange(0, 1);
        rb.AddForce(new Vector3(0, 0, -fallSpeed));
        rotationPosition = Random.rotation;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(new Vector3(10f, 4f, 3f) * Time.deltaTime * rotationSpeed);

           
	}
}
