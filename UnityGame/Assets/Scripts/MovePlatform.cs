using UnityEngine;
using System.Collections;

public class MovePlatform : MonoBehaviour {

	public float distance = 3f;
	public float speed = 1f;
	public Vector3 direction = new Vector3 (0f, 1f, 0f);

	private float distanceMoved;
	private bool goingForward;

	// Use this for initialization
	void Start () {
		distanceMoved = 0f;
		goingForward = true;
	}
	
	// Update is called once per frame
	void Update () {
		distanceMoved += speed * Time.deltaTime;
		if (distanceMoved > distance) {
			goingForward = !goingForward;
			distanceMoved = 0f;
		}
		if (goingForward) {
			transform.Translate (direction * speed * Time.deltaTime);
		}
		if (!goingForward) {
			transform.Translate (direction * -speed * Time.deltaTime);
		}
	}
}
