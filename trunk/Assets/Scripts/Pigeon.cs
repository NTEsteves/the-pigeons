using UnityEngine;
using System.Collections;

public class Pigeon : MonoBehaviour {

	public GameObject pfbBullet;

	private bool mouseDown;

	public static float forceBullet;

	private Transform trans;

	// Use this for initialization
	void Start () {
		trans = GetComponent<Transform>();
		forceBullet = 0;
		mouseDown = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(mouseDown)
		{
			forceBullet += 0.5f;
		}
	}

	void OnMouseDown()
	{
		mouseDown = true;
	}

	void OnMouseUp()
	{
		mouseDown = false;
		GameObject go = Instantiate(pfbBullet, new Vector3(trans.position.x, (trans.position.y -0.5f), trans.position.z), Quaternion.identity) as GameObject;
		go.GetComponent<Bullet> ().setForce (forceBullet);
		forceBullet = 0;
	}
}
