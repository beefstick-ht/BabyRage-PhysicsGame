using System.Collections;
using UnityEngine;

public class Plinko : MonoBehaviour
{
    [Header("Cubes")]
    public bool win;

    public GameObject fire;
    public float spawnDelay;
    public Transform deathRespawn;
    public Transform respawnPoint;

    public GameObject money1;
    public GameObject money2;

    public GameObject chicken;
    public GameObject boxOfDeath;

    public void Win()
    {
        win = true;
    }
    private void Start()
    {
        boxOfDeath.SetActive(false);
        fire.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlinkoWin")
        {
            //start dialogue w/ Angus again
            Debug.Log("Talkin to my boy");
            chicken.transform.position = respawnPoint.position;
        }
        if (other.tag == "BlowUp")
        {
            boxOfDeath.SetActive(true);
            boxOfDeath.transform.position = respawnPoint.position;
            fire.SetActive(true);
            StartCoroutine(Respawning());
            Debug.Log("damn you sploded");

        }
        if (other.tag == "Money1")
        {
            money1.transform.position = respawnPoint.position;
            Debug.Log("RICHES");

        }
        if (other.tag == "Money2")
        {
            money2.transform.position = respawnPoint.position;
            Debug.Log("More RICHES");

        }
    }

    public void Spawn()
    {
        //player's position will be set to the spawnpoint's position
        transform.position = deathRespawn.position;
    }

    IEnumerator Respawning()
    {
        yield return new WaitForSeconds(spawnDelay);
        Spawn();
    }
}
