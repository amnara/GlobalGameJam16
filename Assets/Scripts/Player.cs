using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Camera mainCamera;

	public CameraController cameraController;


	void Start () {
		mainCamera = Camera.main;
		cameraController.Init(transform, mainCamera.transform);
	}

	void Update () {
		cameraController.RotateCamera(transform, mainCamera.transform);
	}
}
