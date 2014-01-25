using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour {
	
	public float health;
	public GameObject ragdoll;
	public bool dead;
	//public Blood bloodScript;
	//public ParticleSystem blood;

	void Update() {
		Blood bloodScript = this.gameObject.GetComponent<Blood> ();
		}
	
	public void TakeDamage(float dmg) {
		health -= dmg;
		
		if (health <= 0) {
			Die();	
		}
	}
	
	public void Die() {
		Ragdoll r = (Instantiate(ragdoll,transform.position,transform.rotation) as GameObject).GetComponent<Ragdoll>();
		r.CopyPose(transform);
		Destroy(this.gameObject);
		dead = true;
		//blood = GetComponent<ParticleSystem> ();
		//blood.Play ();
		//blood = new Blood ();
		bloodScript.Bleed ();

	}

	public bool isDead() {
		return dead;
	}
}
