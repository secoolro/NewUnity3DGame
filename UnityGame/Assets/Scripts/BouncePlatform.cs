using UnityEngine;
using System.Collections;

public class BouncePlatform : MonoBehaviour {
	
	public float power = 7f;
	public Vector3 direction = new Vector3 (0f, 1f, 0f);
	public bool bounceOnlyPlayer = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay (Collider c) {
		if (!bounceOnlyPlayer || c.gameObject.tag == "Player") {
			c.gameObject.GetComponent <Rigidbody> ().AddForce (direction * power, ForceMode.Impulse);
		}
	}
}
