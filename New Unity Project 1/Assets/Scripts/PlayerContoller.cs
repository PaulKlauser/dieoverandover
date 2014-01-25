using UnityEngine;
using System.Collections;

public class PlayerContoller : MonoBehaviour {

	//Player Handling
	public float speed;
	public float acceleration;

	private float currentSpeed;
	private float targetSpeed;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		targetSpeed = Input.GetAxisRaw ("Horizontal");
	}
}
