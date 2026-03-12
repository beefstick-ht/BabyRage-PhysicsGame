using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RespawnTest : MonoBehaviour
{

    public Transform spawnPoint;

    public GameObject fire;

    public float spawnDelay;

    void OnCollisionEnter(Collision other)
    {
        //check if the player is colliding with the object
        if (other.gameObject.CompareTag("Hazard"))
        {
            fire.SetActive(true);
            StartCoroutine(Respawning());
            Debug.Log("timer?");
            
        }
    }

    public void Spawn()
    {
        //player's position will be set to the spawnpoint's position
        fire.SetActive(false);
        transform.position = spawnPoint.position;
    }

    IEnumerator Respawning()
    {
        yield return new WaitForSeconds(spawnDelay);
        Spawn();
    }
}