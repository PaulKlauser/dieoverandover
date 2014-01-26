using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		renderer.enabled = false;
	}
	
	void OnParticleCollision(GameObject particleSystem) {
		renderer.enabled = true;
	}
}
