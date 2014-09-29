using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	Rigidbody2D rig2D;
	Transform trans;
	float force;


	// Use this for initialization
	void Start () {

		rig2D = GetComponent<Rigidbody2D>();
		trans = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		rig2D.AddForce (new Vector2 (ManagerWild.velocity * ManagerWild.direction, -force));
	}

	public void setForce(float f)
	{
		force = f;
	}
}
