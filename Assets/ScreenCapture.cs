using UnityEngine;
using System.Collections;
using System;

public class ScreenCapture : MonoBehaviour
{
	public RenderTexture overviewTexture;
	public GameObject OVcamera;
	public string path;
	//public GameObject camShot;
	public GameObject[] quad=new GameObject[12];
	public static Texture2D storedImg;
	public static int currentQuad=0;
	void Start()
	{
		//OVcamera = GameObject.FindGameObjectWithTag("OverviewCamera");
	}
	
	void LateUpdate()
	{
		
		/*if (Input.GetKeyDown(KeyCode.Q))
		{
			Debug.Log ("SNAP");
			StartCoroutine(TakeScreenShot());
		}*/
		
	}

	void TakeScreen()
	{
		StartCoroutine(TakeScreenShot());
	}
	
	// return file name
	string fileName(int width, int height)
	{
		return string.Format("screen_{0}x{1}_{2}.png",
		                     width, height,
		                     System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
	}
	
	public IEnumerator TakeScreenShot()
	{
		yield return new WaitForEndOfFrame();
		if (currentQuad < 12)
			currentQuad++;
		Camera camOV = OVcamera.GetComponent<Camera>();
		
		RenderTexture currentRT = RenderTexture.active;
		
		RenderTexture.active = camOV.targetTexture;
		camOV.Render();
		Texture2D imageOverview = new Texture2D(camOV.targetTexture.width, camOV.targetTexture.height, TextureFormat.RGB24, false);
		imageOverview.ReadPixels(new Rect(0, 0, camOV.targetTexture.width, camOV.targetTexture.height), 0, 0);
		imageOverview.Apply();
		
		RenderTexture.active = currentRT;
		
		// Encode texture into PNG
		byte[] bytes = imageOverview.EncodeToPNG();
		storedImg = imageOverview;
		// save in memory
		string filename = fileName(Convert.ToInt32(imageOverview.width), Convert.ToInt32(imageOverview.height));
		path += filename;
		
		System.IO.File.WriteAllBytes(path, bytes);
	}
}