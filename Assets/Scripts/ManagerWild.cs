using UnityEngine;
using System.Collections;

public class ManagerWild : MonoBehaviour {

	public static float velocity;

	float intervalChange;
	public static int direction;

	// Use this for initialization
	void Start () {
		intervalChange = Random.Range(2, 5);
		direction = Random.Range (0, 100) % 2 == 0 ? -1 : 1;
	}
	
	// Update is called once per frame
	void Update () {

		intervalChange -= Time.deltaTime;

		if(intervalChange <= 0)
		{
			velocity = Random.Range(0, 6);
			intervalChange = Random.Range(2, 5);
			direction = Random.Range (0, 100) % 2 == 0 ? -1 : 1;
		}
	}
}
