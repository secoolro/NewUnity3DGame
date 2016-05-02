using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	private Text gt;

	// Use this for initialization
	void Start () {
		GlobalVars.textTimer = 0f;
		GlobalVars.text = "";
		gt = gameObject.GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalVars.textTimer > 0f) {
			GlobalVars.textTimer -= Time.deltaTime;
			gt.text = GlobalVars.text;
		} else {
			gt.text = "";
		}
	}
}
