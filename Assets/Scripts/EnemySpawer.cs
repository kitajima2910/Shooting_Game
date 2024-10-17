using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawer : MonoBehaviour
{
    public GameObject enemyPrefabs;
    public float spawnRate = 1.5f;
    public float spawnRadius = 5.0f;
    private float spwanTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(GameManager.instance.GameOver())
            return;

        spwanTimer += Time.deltaTime;
        if (spwanTimer >= spawnRate)
        {
            SpawnEnemy();
            spwanTimer = 0.0f;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, spawnRadius);
    }

    void SpawnEnemy()
    {
        Vector2 randomPos = (Vector2)transform.position + Random.insideUnitCircle.normalized * spawnRadius;
        Instantiate(enemyPrefabs, randomPos, Quaternion.identity);
    }
}
