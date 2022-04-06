using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //public float spawnRate = 0.25f;
    public float spawnRate = 0.25f;
    //public float timeBetweenWaves = 3.0f;

    public int enemyCount;

    public GameObject enemy;
    
    public GameObject[] Spawners;

    bool waveIsDone = true;
    private int spawnerid;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(8, 8);
        enemy.GetComponent<Enemy>().speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (waveIsDone == true)
        {
            StartCoroutine(waveSpawner());
        }
    }
    IEnumerator waveSpawner()
    {
        waveIsDone = false;
        spawnerid = Random.Range(0, 4);
        //Debug.Log(spawnerid);

        if (spawnerid==0)
        {
            enemy.transform.position= Spawners[0].transform.position;
            GameObject enemyClone = Instantiate(enemy);

            //yield return new WaitForSeconds(spawnRate);
        }
        else if(spawnerid==1)
        {
            enemy.transform.position= Spawners[1].transform.position;
            GameObject enemyClone = Instantiate(enemy);

            //yield return new WaitForSeconds(spawnRate);
        }
        else if(spawnerid==2)
        {
            enemy.transform.position= Spawners[2].transform.position;
            GameObject enemyClone = Instantiate(enemy);

            //yield return new WaitForSeconds(spawnRate);
        }
        else if(spawnerid==3)
        {
            enemy.transform.position= Spawners[3].transform.position;
            GameObject enemyClone = Instantiate(enemy);

            //yield return new WaitForSeconds(spawnRate);
        }

        spawnRate = Random.Range(0.5f, 3);
        yield return new WaitForSeconds(spawnRate);

        waveIsDone = true;
    }

}
