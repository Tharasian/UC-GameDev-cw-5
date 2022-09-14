using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCode : MonoBehaviour
{   float randomspawn;
    public Transform left, right;
    public GameObject enemy;
    float SpawnRate = 1.25f;
    private void Start()
    {
        InvokeRepeating( "Spawn" , 0f, Mathf.Clamp(SpawnRate,0.5f,1.25f));
    }
    void Spawn()
    { randomspawn = Random.Range(1, 4);
        if (randomspawn == 1)
        { Instantiate(enemy, left); 
        }
        else if (randomspawn == 2)
        {
            Instantiate(enemy, transform);
        }
        else
        { Instantiate(enemy, right);}
        SpawnRate -= 0.1f;
    }
}

