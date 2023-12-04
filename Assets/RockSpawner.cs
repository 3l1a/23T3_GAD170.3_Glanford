using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{

    [SerializeField] private GameObject fallingRockPrefab;

    [SerializeField] private List<GameObject> rockSP = new List<GameObject>();

    [SerializeField] private List<Rock> rocks = new List<Rock>();

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            Debug.Log("working");

            Vector3 spawnPosition = rockSP[Random.Range(0,rockSP.Count)].transform.position;

            GameObject newRock = Instantiate(fallingRockPrefab, spawnPosition, Quaternion.identity );

            rocks.Add(newRock.GetComponent<Rock>());

            foreach ( Rock rock in rocks)
            {
                rock.name = "Rock";
            }
        }

    }

}
