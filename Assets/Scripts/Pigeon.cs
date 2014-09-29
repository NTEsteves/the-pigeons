using UnityEngine;
using System.Collections;

public class Pigeon : MonoBehaviour {

	public GameObject pfbBullet;

	private bool mouseDown;

	public static float velBullet;

	private Transform trans;

	// Use this for initialization
	void Start () {
		trans = GetComponent<Transform>();
		velBullet = 0;
		mouseDown = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(mouseDown)
		{
			velBullet += 0.05f;
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
		velBullet = 0;
	}
}
