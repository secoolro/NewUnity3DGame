using UnityEngine;
using System.Collections;

public class FollowMe : MonoBehaviour {

	public GameObject followed;
	public float min = 6f;
	public float max = 14f;
	private float groundLevel = 0.27f;
	[Range(6f, 14f)] public float height = 8f;

	//public float distanceRound = 3f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 tmp = followed.transform.position;
		//groundLevel = tmp.y;
		transform.position = new Vector3(tmp.x, groundLevel + height, tmp.z);
		//transform.position = new Vector3(tmp.x, (Mathf.Round(tmp.y / distanceRound) * distanceRound) + height, tmp.z);
		if (Input.GetKey (KeyCode.Z) && height < max) {
			height+=2*Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.X) && height > min) {
			height-=2*Time.deltaTime;
		}
	}
}
