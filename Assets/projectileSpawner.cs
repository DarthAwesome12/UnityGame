using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class projectileSpawner : MonoBehaviour
{

    public float speed = 4.5f;
	public GameObject projectile;
    public GameObject buttons;
	public AudioSource audioSource;
	// Start is called before the first frame update
	void Start()
    {

    float timeOffset = UnityEngine.Random.Range(0f, 3f);

	InvokeRepeating("LaunchProjectile", timeOffset, 1.0f); 
    }

    // Update is called once per frame
    void Update()
    {
        
        


    }

    void LaunchProjectile()
    {      

        
        GameObject instance = Instantiate(projectile, new Vector2(transform.position.x, transform.position.y + transform.localScale.y / 2), Quaternion.identity, gameObject.transform);
        Rigidbody2D instanceRb = instance.AddComponent<Rigidbody2D>();
        instance.AddComponent<ProjectileBehavior>();
        instance.GetComponent<ProjectileBehavior>().buttons = buttons;
		instance.GetComponent<ProjectileBehavior>().audioSource = audioSource;
		instanceRb.gravityScale = 0f;
        instanceRb.mass = 0.1f;
		instanceRb.velocity = new Vector2(0.0f, 20.0f);
        
        instance.AddComponent<BoxCollider2D>();


       

        
       
    }
    
}
