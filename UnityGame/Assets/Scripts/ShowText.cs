using UnityEngine;
using System.Collections;

public class ShowText : MonoBehaviour {

	public string message;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider c) {
		if (c.gameObject.tag == "Player") {
			GlobalVars.textTimer = 3f;
			GlobalVars.text = message;
		}
	}
}
