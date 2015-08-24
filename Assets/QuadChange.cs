using UnityEngine;
using System.Collections;

public class QuadChange : MonoBehaviour {

	private string quadID="0";
	private int sup=0;
	// Use this for initialization
	void Start () {
		quadID=gameObject.name;
	}
	
	// Update is called once per frame
	void Update () {
		if(ScreenCapture.storedImg!=null)
		GetComponent<MeshRenderer> ().material.mainTexture = ScreenCapture.storedImg;
	}
}
