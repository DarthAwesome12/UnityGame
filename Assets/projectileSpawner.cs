using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.UIElements;

public class projectileSpawner : MonoBehaviour
{

    public float speed = 20.0f;
	public GameObject projectile;
    public GameObject buttons;
	public AudioSource audioSource;
    public GameObject directionCheck;
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

        
        GameObject instance = Instantiate(projectile, new Vector2(directionCheck.transform.position.x, directionCheck.transform.position.y), Quaternion.identity, gameObject.transform);
        Rigidbody2D instanceRb = instance.AddComponent<Rigidbody2D>();
        instance.AddComponent<ProjectileBehavior>();
        instance.GetComponent<ProjectileBehavior>().buttons = buttons;
		instance.GetComponent<ProjectileBehavior>().audioSource = audioSource;
		instanceRb.gravityScale = 0f;
        instanceRb.mass = 0.1f;
        Vector2 direction = (directionCheck.transform.position - transform.position).normalized;
		instanceRb.velocity = direction * speed;
        instance.AddComponent<BoxCollider2D>();


       

        
       
    }
    
}
