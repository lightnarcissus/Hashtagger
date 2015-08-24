using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AddHashtag : MonoBehaviour {

	//public string hashtag;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void HashtagInsert(string hashtag)
	{
		//Debug.Log (hashtag);
		if (hashtag.Contains ("#"))
			GetComponent<Text> ().text = hashtag;
		else
			GetComponent<Text> ().text = "#" + hashtag;

	}

}
