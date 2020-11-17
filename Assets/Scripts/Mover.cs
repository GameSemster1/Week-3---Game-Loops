using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves the current GameObject at a set speed.
/// </summary>
public class Mover : MonoBehaviour
{
	[Tooltip("The speed to move this GameObject by, in every axis.")]
	public Vector3 speed;

	private void Update()
	{
		transform.Translate(speed * Time.deltaTime);
	}
}