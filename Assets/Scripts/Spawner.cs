using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] objectPrefabs;
    public float spawnTime;
    public float objectSpeed;
	// Use this for initialization
	void Start () {
        StartCoroutine("SpawnObject");	
	}

    IEnumerator SpawnObject() {
        while(true) {
            Vector3 spawnPosition = new Vector3(Random.RandomRange(-transform.localScale.x, transform.localScale.x),
                                                Random.RandomRange(-transform.localScale.y, transform.localScale.y),
                                                transform.position.z);

            GameObject objectToSpawn = objectPrefabs[Random.Range(0, objectPrefabs.Length)];
            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
            spawnedObject.GetComponent<Mover>().fallSpeed = objectSpeed;
            yield return new WaitForSeconds(spawnTime);
                
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
            //GameObject newCube = (GameObject)Instantiate(cubePrefab, transform.position, Quaternion.identity);
        }
	}

    void OnDrawGizmos() {
        Gizmos.DrawWireCube(transform.position, new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z));
    }
}
