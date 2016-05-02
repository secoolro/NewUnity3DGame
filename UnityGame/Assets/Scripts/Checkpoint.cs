using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	private bool reached;

	// Use this for initialization
	void Start () {
		reached = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider c) {
		if (c.gameObject.tag == "Player" && !reached) {
			reached = true;
			Vector3 tmp = gameObject.transform.position;
			GlobalVars.restartPos = new Vector3(tmp.x + 1.2f, tmp.y + 1f, tmp.z - 1.2f);
			GlobalVars.textTimer = 3f;
			GlobalVars.text = "Checkpoint Reached";
		}
	}
}
