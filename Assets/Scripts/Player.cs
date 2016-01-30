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

		// If Right mouse button
		if(Input.GetMouseButtonDown(1)) {
			var focusedObject = cameraController.GetFocusedObject();

			if(focusedObject != null) {
				Debug.Log("HAS OBJECT: " + focusedObject);
			} else {
				Debug.Log("No cigar");
			}
		}
	}
}
