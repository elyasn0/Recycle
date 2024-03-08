using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] SpawnObjects;

    public GameObject[] sphere;
    public float delay;
    public int maxSpheres;
    public int totalSpheres;
    public int pipeColour;
   
    public void Start()
    {
        SpawnSphere();
    }

    public void SpawnSphere()
    {
        if (totalSpheres < maxSpheres)
        {
            Instantiate(SpawnObjects[Random.Range(0,SpawnObjects.Length)], transform.position, transform.rotation);
            StartCoroutine(ExampleCoroutine());
            FindObjectOfType<AudioManager>().Play("SpawnSound");
            totalSpheres++;
        }

    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(delay);
        SpawnSphere();
    }
}
