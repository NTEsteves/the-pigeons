using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class MyUnityAds : MonoBehaviour {
	
	// Use this for initialization
	void Start () 
	{
		Advertisement.Initialize("20430");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Advertisement.isReady())
		{
			Advertisement.Show();
		}
	}
}
