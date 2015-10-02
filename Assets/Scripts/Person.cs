using UnityEngine;
using System.Collections;

public class Person : MonoBehaviour 
{
	int direction;

	Transform trans;

	Animator anim;

	public AudioClip clickSound;

	public float velocity = 0.01f;

	public int[] limitForDestroy = new int[2];

	void Awake () 
	{
		anim = GetComponent<Animator>();

		trans = GetComponent<Transform>();
	}

	void Update () 
	{
		if(ManagerGame.isPaused) return;

		trans.Translate (new Vector3(velocity * direction, 0, 0));
	
		//if(trans.position.x < limitForDestroy[0] || trans.position.x > limitForDestroy[1])
		if(trans.position.x < ManagerPerson.instance.listPositionCreate[0] || trans.position.x > ManagerPerson.instance.listPositionCreate[1])
		{
			Destroy(this.gameObject);
		}

		GetComponent<AudioSource>().PlayOneShot(clickSound);
	}

	// Metodo para settar a direcao da pessoa (alvo)
	public void setDirection(int d)
	{
		direction = d;
	}

	public void setAnimation(string s)
	{
		anim.SetTrigger(s);
	}
}
