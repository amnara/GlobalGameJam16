using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	Camera camera;
	private Quaternion cameraRotation;
	private Quaternion playerRotation;

	public float XSensitivity = 2.0f;
	public float YSensitivity = 2.0f;

	public void Init(Transform player, Transform camera) {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

		cameraRotation = camera.localRotation;
		playerRotation = player.localRotation;
	}

	public void RotateCamera(Transform player, Transform camera)
	{
		float yRot = Input.GetAxis("Mouse X") * XSensitivity;
		float xRot = Input.GetAxis("Mouse Y") * YSensitivity;

		cameraRotation *= Quaternion.Euler (-xRot, 0f, 0f);
		cameraRotation = LimitVerticalRotation (cameraRotation);

		playerRotation *= Quaternion.Euler (0f, yRot, 0f);

		camera.localRotation = cameraRotation;
		player.localRotation = playerRotation;
	}

	Quaternion LimitVerticalRotation(Quaternion q)
	{
		q.x /= q.w;
		q.y /= q.w;
		q.z /= q.w;
		q.w = 1.0f;

		float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan (q.x);

		angleX = Mathf.Clamp (angleX, -90f, 90f);

		q.x = Mathf.Tan (0.5f * Mathf.Deg2Rad * angleX);

		return q;
	}
}
