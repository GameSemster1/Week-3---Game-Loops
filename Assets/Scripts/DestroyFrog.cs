using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFrog : MonoBehaviour
{
	[SerializeField] string triggeringTag;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == triggeringTag)
		{
			Destroy(this.gameObject);
			// Destroy(other.gameObject);
		}
	}
}