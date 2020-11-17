using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Repeatedly spawns a random GameObject from a given array.
/// </summary>
public class ArraySpawner : MonoBehaviour
{
	[Tooltip("The GameObject to spawn.")] public GameObject[] toSpawn;

	[Tooltip("The spawning rate (per second).")]
	public float rate = 1;

	[Tooltip("The variance of the spawning rate (per second).")]
	public float randomVariance = 0;

	private void Start()
	{
		StartCoroutine(SpawningCorutine());
	}

	/// <summary>
	/// Repeatedly spawns a random GameObject from <see cref="ArraySpawner.toSpawn"/>,
	/// waiting between '<see cref="ArraySpawner.rate"/> - <see cref="ArraySpawner.randomVariance"/>'
	/// and '<see cref="ArraySpawner.rate"/> + <see cref="ArraySpawner.randomVariance"/>'
	/// before every spawn.
	/// </summary>
	private IEnumerator SpawningCorutine()
	{
		while (true)
		{
			yield return new WaitForSeconds(rate + randomVariance * (1 - Random.value * 2));

			Instantiate(toSpawn[Random.Range(0, toSpawn.Length)], transform.position, transform.rotation);
		}
	}
}