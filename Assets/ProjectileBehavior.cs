using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
	public GameObject buttons;
	public AudioSource audioSource;
	// Start is called before the first frame update
	void Start()
    {
	
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnCollisionEnter2D(Collision2D col)
	{

		
		if (col.gameObject.name == "Player")
		{
			col.gameObject.GetComponent<Renderer>().material.color = Color.red;
			Destroy(gameObject);
			Time.timeScale = 0f;
			buttons.SetActive(true);
			if (OptionsMenu.easterEgg)
			{
				audioSource.Play();

			}
		}
	}
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
