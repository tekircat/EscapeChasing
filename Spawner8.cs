using System.Collections;
using UnityEngine;

public class Spawner8 : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
    int randEnemy;

    void Start()
    {
        StartCoroutine(waitSpawner());

    }

    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);

    }
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (!stop)
        {
            randEnemy = Random.Range(0, 4);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, -spawnValues.x), 0, Random.Range(-spawnValues.z, -spawnValues.z));
            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
