using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CameraFollow : MonoBehaviour
{ 
    public GameObject player;
    private Camera cam;
	
	// Start is called before the first frame update
	void Start()
    {
        cam = GetComponent<Camera>();
		//Set Antialiasing settings
		UniversalAdditionalCameraData additionalCameraData = cam.transform.GetComponent<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>();
        switch (PlayerPrefs.GetInt("AAType", 0)) { 
        
            case 0:
                additionalCameraData.antialiasing = AntialiasingMode.None;
                break;
            case 1:
                additionalCameraData.antialiasing = AntialiasingMode.FastApproximateAntialiasing;
                break;
            case 2:
                additionalCameraData.antialiasing = AntialiasingMode.SubpixelMorphologicalAntiAliasing;
                break;
        }

        switch (PlayerPrefs.GetInt("AAQuality", 0)) {
            case 0:
                additionalCameraData.antialiasingQuality = AntialiasingQuality.Low; 
                break;
            case 1:
                additionalCameraData.antialiasingQuality = AntialiasingQuality.Medium;
                break;
            case 2:
                additionalCameraData.antialiasingQuality = AntialiasingQuality.High;
                break;
        }
        Debug.Log(additionalCameraData.antialiasing);


	}

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    }

}
