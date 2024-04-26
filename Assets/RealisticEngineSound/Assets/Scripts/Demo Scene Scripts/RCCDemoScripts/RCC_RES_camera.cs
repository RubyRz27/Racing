//______________________________________________//
//___________Realistic Engine Sounds____________//
//______________________________________________//
//_______Copyright © 2017 Yugel Mobile__________//
//______________________________________________//
//_________ http://mobile.yugel.net/ ___________//
//______________________________________________//
//________ http://fb.com/yugelmobile/ __________//
//______________________________________________//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RCC_RES_camera : MonoBehaviour {

    RCC_Camera rccCamera;
    private GameObject rccCarCamera;
    private GameObject cameraButton;
	public string cameraName = "RCCCamera";
    public GameObject exteriorSounds;
    public GameObject interiorSounds;
    private int currentCamera;

    void Start()
    {
        rccCarCamera = GameObject.Find(""+cameraName);
        cameraButton = GameObject.Find("Change Camera Button");
        rccCamera = rccCarCamera.GetComponent<RCC_Camera>();
        if (rccCamera.cameraMode == RCC_Camera.CameraMode.FPS)
        {
            // switch sounds
            exteriorSounds.SetActive(false);
            interiorSounds.SetActive(true);
        }
        else
        {
            // switch sounds
            exteriorSounds.SetActive(true);
            interiorSounds.SetActive(false);
        }
    }
    void LateUpdate()
    {
        // interior camera
        if (rccCamera.cameraMode == RCC_Camera.CameraMode.FPS)
        {
            if (currentCamera != 1)
            {
                // switch sounds
                exteriorSounds.SetActive(false);
                interiorSounds.SetActive(true);
                currentCamera = 1;
            }
        }
        // exterior cameras
        if (rccCamera.cameraMode == RCC_Camera.CameraMode.TPS)
        {
            if (currentCamera != 2)
            {
                // switch sounds
                exteriorSounds.SetActive(true);
                interiorSounds.SetActive(false);
                currentCamera = 2;
            }
        }
        if (rccCamera.cameraMode == RCC_Camera.CameraMode.WHEEL)
        {
            if (currentCamera != 3)
            {
                // switch sounds
                exteriorSounds.SetActive(true);
                interiorSounds.SetActive(false);
                currentCamera = 3;
            }
        }
        if (rccCamera.cameraMode == RCC_Camera.CameraMode.FIXED)
        {
            if (currentCamera != 4)
            {
                // switch sounds
                exteriorSounds.SetActive(true);
                interiorSounds.SetActive(false);
                currentCamera = 4;
            }
        }
        if (rccCamera.cameraMode == RCC_Camera.CameraMode.CINEMATIC)
        {
            if (currentCamera != 5)
            {
                // switch sounds
                exteriorSounds.SetActive(true);
                interiorSounds.SetActive(false);
                currentCamera = 5;
            }
        }
        if (rccCamera.cameraMode == RCC_Camera.CameraMode.TOP)
        {
            if (currentCamera != 6)
            {
                // switch sounds
                exteriorSounds.SetActive(true);
                interiorSounds.SetActive(false);
                currentCamera = 6;
            }
        }
    }
}
