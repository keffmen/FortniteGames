using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generating_objects : MonoBehaviour
{
    [SerializeField]
    public GameObject[] ColdObject;
    private int RandomItem;
    float RandY;
    [SerializeField]
    private float spawnRage = 0.01f;
    float nextSpawn = 0.0f;
    float nextRaund = 15;

    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRage;
            RandomItem = Random.Range(0, ColdObject.Length);
            RandomSpawn();
        }
        if (Time.time >= nextRaund)
        {
            nextRaund += 15;
            spawnRage -= 1;
            if (spawnRage == 0)
                spawnRage = 1;
            
        }
    }

    private void RandomSpawn()
    {
        RandY = Random.Range(-4.2f, 4.2f);
        Instantiate(ColdObject[RandomItem], new Vector3(transform.position.x, RandY), ColdObject[RandomItem].transform.rotation);
        
    }
}
