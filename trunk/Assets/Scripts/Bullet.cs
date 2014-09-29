using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	Rigidbody2D rig2D;

	float velocity;


	// Use this for initialization
	void Start () {
		rig2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rig2D.AddForce(new Vector2(ManagerWild.velocity, -Pigeon.velBullet));

		Debug.Log(Pigeon.velBullet);
	}
}
