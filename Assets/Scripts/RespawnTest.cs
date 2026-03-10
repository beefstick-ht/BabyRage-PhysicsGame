using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Respawn : MonoBehaviour
{

    public Transform spawnPoint;

    public GameObject fire;

    public float spawnDelay;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        //check if the player is colliding with the object
        if (other.gameObject.CompareTag("Hazard"))
        {
            fire.SetActive(true);
            StartCoroutine(Respawning());
            Spawn();
        }
    }

    public void Spawn()
    {
        //player's position will be set to the spawnpoint's position
        transform.position = spawnPoint.position;
    }

    IEnumerator Respawning()
    {
        yield return new WaitForSeconds(spawnDelay);
    }
}