using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    List<GameObject> enemies;
    int maxEnemy = 1;
    private GameObject enemyPrefab;
    private GameObject enemySpawnPos;
    private float timer = 0;
    private float delay = 2f;
    float layerOrder = 0;
    private void Awake()
    {
        enemyPrefab = GameObject.Find("EnemyPrefab");
        enemyPrefab = GameObject.Find("EnemySpawnPos");
        enemyPrefab.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        enemies = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
        CheckDead();
    }
    public void Spawn()
    {
        if (PlayerCtrl.instance.DamageReceiver.IsDead()) return;
        if (enemies.Count >= maxEnemy) return;

        timer += Time.deltaTime;
        if (timer < delay) return;

        timer = 0;
        GameObject enemy = Instantiate(enemyPrefab);
        enemy.SetActive(true);
        enemy.transform.position = enemySpawnPos.transform.position;
        enemies.Add(enemy);
    }
    public void CheckDead()
    {
        for (int i = 0; i < enemies.Count; i++)
        {

            if (enemies[i] == null)
            {
                enemies.RemoveAt(i);
            }
        }
    }
}
