using UnityEngine;
using System.Collections;

public class ManagerWild : MonoBehaviour {

	public static float velocity;

	float intervalChange;		

	// Use this for initialization
	void Start () {
		intervalChange = Random.Range(2, 5);
	}
	
	// Update is called once per frame
	void Update () {
		intervalChange -= Time.deltaTime;
		if(intervalChange <= 0)
		{
			velocity = Random.Range(0, 10);
			intervalChange = Random.Range(2, 5);
		}
	}
}
