using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
	float leftLimitPlayer;
	float rightLimitPlayer;
	float topLimitPlayer;
	float bottomLimitPlayer;
	private float jump = 2f;

	/// <summary>
	/// The key that moves the gameobject forward (or up).
	/// </summary>
	[Tooltip("The key that moves the gameobject forward (or up).")]
	private KeyCode up = KeyCode.UpArrow;

	/// <summary>
	/// The key that moves the gameobject backwards (or down).
	/// </summary>
	[Tooltip("The key that moves the gameobject backwards (or down).")]
	private KeyCode down = KeyCode.DownArrow;

	/// <summary>
	/// The key that moves the gameobject right.
	/// </summary>
	[Tooltip("The key that moves the gameobject right.")]
	private KeyCode right = KeyCode.RightArrow;

	/// <summary>
	/// The key that moves the gameobject left.
	/// </summary>
	[Tooltip("The key that moves the gameobject left.")]
	private KeyCode left = KeyCode.LeftArrow;


	public float screenOffset;

	private void Start()
	{
		var cam = Camera.main;

		if (cam == null)
			return;

		Vector3 max = cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, cam.pixelHeight, 0));
		Vector3 min = cam.ScreenToWorldPoint(new Vector3(0, 0, 0));

		leftLimitPlayer = min.x - screenOffset;
		rightLimitPlayer = max.x + screenOffset;

		topLimitPlayer = max.y + screenOffset;
		bottomLimitPlayer = min.y - screenOffset;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(up))
		{
			transform.Translate(Vector3.up * jump);
		}

		if (Input.GetKeyDown(down))
		{
			transform.Translate(Vector3.down * jump);
		}

		if (Input.GetKeyDown(right))
		{
			transform.Translate(Vector3.right * jump);
		}

		if (Input.GetKeyDown(left))
		{
			transform.Translate(Vector3.left * jump);
		}

		transform.position = new Vector3
		(
			Mathf.Clamp(transform.position.x, leftLimitPlayer, rightLimitPlayer),
			Mathf.Clamp(transform.position.y, bottomLimitPlayer, topLimitPlayer),
			transform.position.z
		);
	}
}