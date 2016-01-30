using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Camera camera;
	CameraController cameraController;

	public float XSensitivity = 2.0f;
	public float YSensitivity = 2.0f;


	// Use this for initialization
	void Start () {
		
		camera = Camera.main;
		cameraController = new CameraController();
		cameraController.Init(transform, camera.transform);
	}

	// Update is called once per frame
	void Update () {
		cameraController.RotateCamera(transform, camera.transform);
	}
}
