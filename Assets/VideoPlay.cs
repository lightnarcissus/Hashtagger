using UnityEngine;
using System.Collections;

public class VideoPlay : MonoBehaviour {
	public MovieTexture movTexture;
	void Update () {
			movTexture.Play();
			movTexture.loop=true;
			//Debug.Log ("PLLAY");
	}
}