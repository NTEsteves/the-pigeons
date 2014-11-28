using UnityEngine;
using System.Collections;

public class Pigeon : MonoBehaviour 
{
	//Atributo que sera usado para referenciar qual prefab nos queremos instanciar
	public GameObject bullet;

	private bool mouseDown;

	private AudioSource audioSource;

	private float forceBullet;

	public static float lastForceBullet;

	private Transform trans;

	public AudioClip clickSound ;

	void Start () 
	{
		trans = GetComponent<Transform>();
		audioSource = GetComponent<AudioSource>();
		forceBullet = 0;
		mouseDown = false;
		lastForceBullet = 0;
	}
	
	void Update () 
	{
		if(ManagerGame.isPaused) return;

		//Condiçao que verifica se o player ainda esta sendo pressionado, caso sim ele continua atribuindo força ao tiro
		if(mouseDown)
		{
			if(forceBullet <= 5)
			{
				forceBullet += 0.1f;
			}

			lastForceBullet = forceBullet;
		}

		// Atribuindo o valor universal do audio do game
		audioSource.mute = ManagerGame.isMute;
	}

	void OnMouseDown()
	{
		mouseDown = true;
	}

	void OnMouseUp()
	{
		if(ManagerGame.isPaused) return;

		audio.PlayOneShot(clickSound);

		GameObject go = Instantiate(bullet, new Vector3(trans.position.x, (trans.position.y -0.3f), trans.position.z), Quaternion.identity) as GameObject;

		go.GetComponent<Bullet>().setForce(forceBullet);

		forceBullet = 0;

		mouseDown = false;
	}
}
