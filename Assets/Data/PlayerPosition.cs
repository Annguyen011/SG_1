using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public float playerPosX;
    List<GameObject> minions;
    public GameObject minionPrefab;
    public float spawnTimer = 0;
    public float spawnDelay = 1;
    // Start is called before the first frame update
    void Start()
    {
        minions = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
            this.Spawn();
        
        this.CheckMinionDead();
    }
    void Spawn()
    {
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer > spawnDelay) return;
        this.spawnTimer = 0;
        Debug.Log("Spawn");
        if (minions.Count >= 7) return;
        GameObject minion = Instantiate(this.minionPrefab);
        minion.name = "Bomb";
        minion.transform.position = transform.position;
        minion.gameObject.SetActive(true);
        this.minions.Add(minion);
    }
    public void CheckMinionDead()
    {
        for (int i = 0; i < minions.Count; i++)
        {

            if (minions[i] == null)
            {
                minions.RemoveAt(i);
            }
        }
    }
}
