using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	public bool Open;

	private Animator anim;

	private GameObject player;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		anim = GetComponent<Animator> ();
	}
	void OnTriggerEnter (Collider other){
		anim.SetBool ("Open", true);
	}

	void OnTriggerExit (Collider other){
		anim.SetBool ("Open", false);
	
	
	}
}
