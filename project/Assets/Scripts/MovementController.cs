using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public float velocity;

	// Use this for initialization
	void Start () {
        velocity = 2f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * -1 * velocity * Time.deltaTime, 0f, 0f));
        transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * -1 * velocity * Time.deltaTime, 0f));

	}
}
