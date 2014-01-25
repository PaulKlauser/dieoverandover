using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float playerSpeed = 5.0f;

	// Use this for initialization
	void Start () {

		//Player spawn point

		//Where the player will start when the game is played

		transform.position = new Vector2 (0, 3);
	
	}
	
	// Update is called once per frame
	void Update () {

		//player to move left/right, with arrow keys

		transform.Translate (Vector3.right * Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime);
		transform.Translate (Vector3.up * Input.GetAxis ("Jump"));
	
	}
}
