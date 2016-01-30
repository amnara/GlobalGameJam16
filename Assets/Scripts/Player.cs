using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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
			GameObject focusedObject = GetFocusedObject();

			if(focusedObject != null) {
				Debug.Log("HAS OBJECT: " + focusedObject);
			} else {
				Debug.Log("No cigar");
			}
		}
	}

	public GameObject GetFocusedObject() {
		List<RaycastHit> hits = new List<RaycastHit>();
		GameObject closestObject = null;
		float closestDistance = Mathf.Infinity;

		Ray ray = cameraController.GetCenterRay();

		hits.AddRange(Physics.RaycastAll(ray.origin, ray.direction));

		foreach(RaycastHit hit in hits) {
			GameObject go = hit.collider.gameObject;
			//			Debug.Log("HIT SOMETHING?:\n "+ go);

			// Only add if throwable for now
			if(go.tag == "Throwable" && hit.distance < closestDistance) {
				Debug.Log("Aww yiss");
				closestObject = go;
				closestDistance = hit.distance;
			}
		}

		return closestObject;
	}
}
