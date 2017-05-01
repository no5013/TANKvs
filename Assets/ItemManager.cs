using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

	public Transform[] itemSpawnPoints;

	public GameObject[] items;

	public float spawnTime = 10f;



	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	// Update is called once per frame
	void Spawn () {
		int spawnPointIndex = Random.Range (0, itemSpawnPoints.Length);
		int itemIndex = Random.Range (0, items.Length);

		print (spawnPointIndex);
		print (itemIndex);

		Instantiate (items [itemIndex], itemSpawnPoints [spawnPointIndex].position, itemSpawnPoints [spawnPointIndex].rotation);
	}
}
