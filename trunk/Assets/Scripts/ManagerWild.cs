using UnityEngine;
using System.Collections;

public class ManagerWild : MonoBehaviour {

	public static float velocity;
	public float[] intervalVelocity = new float[2];

	float timeChange;
	public float[] intervalChange = new float[2];

	public static int direction;
	public float[] intervalDirection = new float[2]; 

	// Use this for initialization
	void Start () {
		timeChange = Random.Range(intervalVelocity[0], intervalVelocity[1]);
		direction = Random.Range (intervalDirection[0], intervalDirection[1]) % 2 == 0 ? -1 : 1;
	}
	
	// Update is called once per frame
	void Update () {

		timeChange -= Time.deltaTime;

		if(timeChange <= 0)
		{
			velocity = Random.Range(intervalVelocity[0], intervalVelocity[1]);
			timeChange = Random.Range(intervalChange[0], intervalChange[1]);
			direction = Random.Range (intervalDirection[0], intervalDirection[1]) % 2 == 0 ? -1 : 1;
		}
	}
}
