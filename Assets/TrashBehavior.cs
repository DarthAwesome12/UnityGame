using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class TrashBehavior : MonoBehaviour
{

    public GameObject trashFab;
    public GameObject groundSize;
    public TMP_Text scoreText;
    

    public int trashCollected = 0;
	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.tag == "Trash") { 
        
            trashCollected++;
            scoreText.text = "Score: " + trashCollected.ToString();
            
            GameObject instance = Instantiate(trashFab, new Vector3(Random.Range(2f, groundSize.transform.lossyScale.x), groundSize.transform.position.y + 2f, Random.Range(2f, groundSize.transform.lossyScale.z)), Quaternion.identity);
            Debug.Log(groundSize.transform.position); ;
			Destroy(collision.gameObject);
		}
	}
}
