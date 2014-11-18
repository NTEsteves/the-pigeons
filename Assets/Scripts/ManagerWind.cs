using UnityEngine;
using System.Collections;

public class ManagerWind : MonoBehaviour {

	public static float velocity;
	public float[] intervalVelocity = new float[2];

	float timeChange;
	public float[] intervalTimeChange = new float[2];

	public static float direction;
	public float[] intervalDirection = new float[2]; 

	// Use this for initialization
	void Start () {
		timeChange = Random.Range(intervalVelocity[0], intervalVelocity[1]);
		direction = Random.Range (intervalDirection[0], intervalDirection[1]) % 2 == 0 ? -1 : 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(ManagerGame.isPaused) return;

		timeChange -= Time.deltaTime;

		if(timeChange <= 0)
		{
			velocity = Random.Range(intervalVelocity[0], intervalVelocity[1]);
			timeChange = Random.Range(intervalTimeChange[0], intervalTimeChange[1]);
			direction = Random.seed % 2 >= 0 ? 1 : -1;
		}
	}
}
