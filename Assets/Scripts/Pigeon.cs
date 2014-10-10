using UnityEngine;
using System.Collections;

public class Pigeon : MonoBehaviour {

	//Atributo que sera usado para referenciar qual prefab nos queremos instanciar
	public GameObject bullet;

	private bool mouseDown;

	float forceBullet;
	public static float lastForceBullet;

	private Transform trans;
	public AudioClip clickSound ;

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
			if(forceBullet <= 5)
			{
				forceBullet += 0.1f;
			}

			lastForceBullet = forceBullet;
		}
	}

	void OnMouseDown()
	{
		mouseDown = true;
	}

	void OnMouseUp()
	{
		audio.PlayOneShot(clickSound);
		createBullet ();
		mouseDown = false;
	}

	void createBullet()
	{
		GameObject go = Instantiate(bullet, new Vector3(trans.position.x, (trans.position.y -0.3f), trans.position.z), Quaternion.identity) as GameObject;
		go.GetComponent<Bullet> ().setForce (forceBullet);
		forceBullet = 0;
	}
}
