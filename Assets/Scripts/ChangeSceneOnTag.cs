using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnTag : MonoBehaviour
{
	public string theTag;

	public string sceneName;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag(theTag))
		{
			SceneManager.LoadScene(sceneName);
		}
	}
}