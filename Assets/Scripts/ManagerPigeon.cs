using UnityEngine;
using System.Collections;

public class ManagerPigeon : MonoBehaviour {

	public GameObject pigeon;
	public AudioClip clickSound;

	AudioSource audioSource;
	Vector3 touch2D;
	bool goInstance;
	float[] placePopulated = new float[12];
	float[] targets = new float[13]{-4.8f, -4.0f, -3.2f, -2.4f, -1.6f, -0.8f, 0, 0.8f, 1.6f, 2.4f, 3.2f, 4.0f, 4.8f};

	// Use this for initialization
	void Start () {
		goInstance = false;
		audioSource = GetComponent<AudioSource>();
	}
	

	// Update is called once per frame
	void Update () {
		if(ManagerGame.isPaused) return;
		audioSource.mute = ManagerGame.isMute;

		if(Input.GetMouseButtonDown(0))
		{
			// Foi criada um metodo estatico no script ManagerGame para converter as coordenadas do touch de 3D para 2D
			touch2D = ManagerGame.convertCoordMouse2D (new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

		}
		else
		{
			if(Input.touchCount > 1)
			{
				// Foi criada um metodo estatico no script ManagerGame para converter as coordenadas do touch de 3D para 2D
				touch2D = ManagerGame.convertCoordMouse2D (new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, 0));

			}

		}
		
		if(goInstance)
		{
			bool populated = false;
			float place = 0;
			for(int i = 0; i < targets.Length; i++)
			{
				if(touch2D.x >= targets[i] && touch2D.x <= targets[i +1])
				{
					place = ((targets[i] + targets[i +1]) /2); 

					for(int j = 0; j < placePopulated.Length; j++)
					{
						if(place.Equals(placePopulated[j]))
						{
							populated  = true;
						}
					}

					if(!populated)
					{
						GameObject go = Instantiate (pigeon, new Vector3(place, touch2D.y, 0), Quaternion.identity) as GameObject;
						audio.PlayOneShot(clickSound);
						goInstance = !goInstance;
						placePopulated[i] = place;
					}
				}
			}
		}
	}

	void OnMouseDown()
	{
		goInstance = !goInstance;
	}
}