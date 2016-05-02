using UnityEngine;
using System.Collections;

public class DeathWater : MonoBehaviour {

	public Vector3 startPos;
	public GameObject player;
	// Use this for initialization
	void Start () {
		startPos = player.transform.position;
		GlobalVars.restartPos = startPos;
		GlobalVars.deathCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider c) {
		if (c.gameObject.tag == "Player") {
			GlobalVars.deathCount++;
			GlobalVars.textTimer = 3f;
			if (GlobalVars.deathCount == 1) {
				GlobalVars.text = "You have fallen " + GlobalVars.deathCount + " time.";
			} else {
				GlobalVars.text = "You have fallen " + GlobalVars.deathCount + " times.";
			}
			player.transform.position = GlobalVars.restartPos;
		}
	}
}
