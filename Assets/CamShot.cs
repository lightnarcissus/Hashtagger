using UnityEngine;
using System.Collections;

public class CamShot : MonoBehaviour {

	public GameObject screenCap;	
	public GameObject socialManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown()
	{
		Debug.Log ("CAM SHOT");
		screenCap.SendMessage ("TakeScreen");
		SocialMediaManager.hashCounter = 1;
		socialManager.SendMessage ("EnterHashtag");
	}
}
