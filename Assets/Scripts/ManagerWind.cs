using UnityEngine;
using System.Collections;

public class ManagerWind : MonoBehaviour {

	public static float velocity;
	public float[] intervalVelocity = new float[2];

	float timeChange;
	public float[] intervalTimeChange = new float[2];

	public static int direction;
	public float[] intervalDirection = new float[2]; 
	private Animator anim;

	void Awake()
	{
		anim = GetComponent<Animator>();
	}

	// Use this for initialization
	void Start ()
	{
		timeChange = Random.Range(intervalVelocity[0], intervalVelocity[1]);
		direction = Random.Range (intervalDirection[0], intervalDirection[1]) % 2 == 0 ? -1 : 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//se ey woih sdokhs dlkhsd lkjshd lks hd
		if(ManagerGame.isPaused) return;

		//vou aspdkjnsopdj sopid sh d
		timeChange -= Time.deltaTime;

		//se sojhd osjhd ojsh dojh sdfjoxc
		if(timeChange <= 0)
		{
			velocity = Random.Range(intervalVelocity[0], intervalVelocity[1]);
			timeChange = Random.Range(intervalTimeChange[0], intervalTimeChange[1]);
			direction = Random.seed % 2 == 0 ? 1 : -1;

		}


		Debug.Log ("direction " + direction);

		if(direction == 1)
		{
			anim.SetTrigger("Flag_right");
		}

		if(direction == -1)
		{
			anim.SetTrigger("Flag_left");
		}

	}
}
