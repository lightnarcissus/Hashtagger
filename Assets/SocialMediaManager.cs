using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SocialMediaManager : MonoBehaviour {

	public GameObject hashtag1;
	public GameObject inputField1;
	public GameObject hashtag2;
	public GameObject inputField2;
	public GameObject hashtag3;
	public GameObject inputField3;
	public GameObject hashtag4;
	public GameObject inputField4;
	public GameObject hashtag5;
	public GameObject inputField5;
	public GameObject hashtag6;
	public GameObject inputField6;
	public static int hashCounter=0;
	public GameObject heart;
	public string hashText;
	public GameObject camShot;
	public GameObject postButton;
	public GameObject postCam;
	public GameObject comments;
	public GameObject likeText;
	public GameObject imageQuad;
	public GameObject camQuad;
	// Use this for initialization
	void Start () {

		EnterHashtag ();
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (hashCounter);
	
	}

	void EnterHashtag()
	{


		if (hashCounter == 0) {
			postCam.SetActive(false);
			heart.SetActive (false);
			comments.SetActive (false);
			inputField1.SetActive (false);
			inputField2.SetActive (false);
			inputField3.SetActive (false);
			inputField4.SetActive (false);
			inputField5.SetActive (false);
			inputField6.SetActive (false);
			hashtag6.SetActive (false);
			hashtag5.SetActive (false);
			hashtag4.SetActive (false);
			hashtag3.SetActive (false);
			hashtag2.SetActive (false);
			hashtag1.SetActive (false);
			camShot.SetActive (true);
			likeText.SetActive (false);
			postButton.SetActive (false);
			imageQuad.SetActive(false);
			camQuad.SetActive(true);

		} else {
			postCam.SetActive (true);
			camQuad.SetActive(false);
			postButton.SetActive(true);
			imageQuad.SetActive(true);
			camShot.SetActive (false);
			//hashCounter++;
		}
		if (hashCounter == 1) {
			Debug.Log ("INSIDE 1");
			postCam.SetActive (true);imageQuad.SetActive(true);
			camShot.SetActive (false);
			hashtag1.SetActive (true);
			hashText = inputField1.GetComponent<InputField> ().text;
			hashtag1.SendMessage ("HashtagInsert", hashText);
			inputField6.SetActive (false);
			inputField1.SetActive (true);

		} else if (hashCounter == 2) {
			Debug.Log ("INSIDE 2");
			hashtag2.SetActive (true);
			hashText = inputField2.GetComponent<InputField> ().text;
			hashtag2.SendMessage ("HashtagInsert", hashText);
			inputField1.SetActive (false);
			inputField2.SetActive (true);
		} else if (hashCounter == 3) {
			hashtag3.SetActive (true);
			hashText = inputField3.GetComponent<InputField> ().text;
			hashtag3.SendMessage ("HashtagInsert", hashText);
			inputField2.SetActive (false);
			inputField3.SetActive (true);
		} else if (hashCounter == 4) {
			hashtag4.SetActive (true);
			hashText = inputField4.GetComponent<InputField> ().text;
			hashtag4.SendMessage ("HashtagInsert", hashText);
			inputField3.SetActive (false);
			inputField4.SetActive (true);
		} else if (hashCounter == 5) {
			hashtag5.SetActive (true);
			hashText = inputField5.GetComponent<InputField> ().text;
			hashtag5.SendMessage ("HashtagInsert", hashText);
			inputField4.SetActive (false);
			inputField5.SetActive (true);
		} else if (hashCounter == 6) {
			hashtag6.SetActive (true);
			hashText = inputField6.GetComponent<InputField> ().text;
			hashtag6.SendMessage ("HashtagInsert", hashText);
			inputField5.SetActive (false);
			inputField6.SetActive (true);
		} 
		else if (hashCounter > 6) {
			inputField6.SetActive (false);
		}

	}
	void UpdateHashCounter()
	{
		hashCounter++;
		EnterHashtag ();
	}

	void PostButton()
	{
		hashCounter = 7;
		inputField1.SetActive (false);
		inputField2.SetActive (false);
		inputField3.SetActive (false);
		inputField4.SetActive (false);
		inputField5.SetActive (false);
		inputField6.SetActive (false);
		heart.SetActive (true);
		likeText.SetActive (true);
		postButton.SetActive (false);
		comments.SetActive (true);
	}
}
