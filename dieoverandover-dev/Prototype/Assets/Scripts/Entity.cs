using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour {
	
	public float health;
	public GameObject ragdoll;
	public bool dead;
	//public Blood bloodScript;
	//public ParticleSystem blood;
	//public GameObject blood;
	public ParticleSystem bloodParticles;

	/*void Update() {
		Blood bloodScript = this.gameObject.GetComponent<Blood> ();
		}*/
	
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
		//bloodScript.Bleed ();
		//GameObject go = (GameObject)Instantiate (Resources.Load ("blood"));
		//GameObject b = (Instantiate (Resources.Load ("blood"), transform.position, transform.rotation) as GameObject);
		Instantiate (bloodParticles, transform.position, transform.rotation);


	}

	public bool isDead() {
		return dead;
	}
}
