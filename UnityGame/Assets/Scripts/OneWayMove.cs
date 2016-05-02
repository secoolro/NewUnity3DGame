using UnityEngine;
using System.Collections;

public class OneWayMove : MonoBehaviour {
	
	private bool start;
	private float speed;
	private float distTravelled;

	private Vector3 startPos;

	public float distance;
	public Vector3 direction;
	
	// Use this for initialization
	void Start () {
		start = false;
		speed = 0f;
		distTravelled = 0f;
		startPos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (direction * Time.deltaTime * speed);
		if (start) {
			if (speed < 8f) {
				speed += 1.5f * Time.deltaTime;
			}
			distTravelled += Time.deltaTime * speed;
			if (distTravelled > distance) {
				start = false;
			}
		} else {
			if (speed > 0f) {
				speed -= 1.5f * Time.deltaTime;
			} else {
				gameObject.transform.position = startPos;
				distTravelled = 0f;
			}
		}
	}
	
	void OnTriggerEnter (Collider c) {
		if (c.gameObject.tag == "Player") {
			start = true;
		}
	}
}