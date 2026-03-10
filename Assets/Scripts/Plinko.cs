using System.Collections;
using UnityEngine;

public class Plinko : MonoBehaviour
{
    [Header("Cubes")]
    public bool win;

    public GameObject fire;
    public float spawnDelay;
    public Transform deathRespawn;
    public void Win()
    {
        win = true;
    }
    private void Start()
    {
        fire.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlinkoWin")
        {
            //start dialogue w/ Angus again
            Debug.Log("Talkin to my boy");
        }
        if (other.tag == "BlowUp")
        {
            fire.SetActive(true);
            StartCoroutine(Respawning());
            Debug.Log("damn you sploded");

        }
        if (other.tag == "Money1")
        {
            Debug.Log("RICHES");

        }
        if (other.tag == "Money2")
        {
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
