using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class RoadSpawner : MonoBehaviour
{
    public GameObject roadPrefab;
    public GameObject roadSpawnPos;
    public GameObject roadCurrent;
    public float distance = 0;
    private void Awake()
    {
        roadPrefab = GameObject.Find("RoadPrefab");
        roadSpawnPos = GameObject.Find("RoadSpawnPos");
        roadPrefab.gameObject.SetActive(false);
        roadCurrent = roadPrefab;
        Spawn(roadPrefab.transform.position);
    }
    private void FixedUpdate()
    {
        UpdateRoad();
    }
    public void UpdateRoad()
    {
        distance = Vector2.Distance(PlayerCtrl.instance.transform.position, roadCurrent.transform.position);
        if (distance >= 40) Spawn();
    }
    public void Spawn()
    {
        Vector3 pos =  roadSpawnPos.transform.position;
        pos.x = 0;
        this.Spawn(pos);
        //roadCurrent = Instantiate(roadPrefab,pos ,roadPrefab.transform.rotation);
        //roadCurrent.SetActive(true);

    }
    public void Spawn(Vector3 positoin)
    {
        roadCurrent = Instantiate(roadPrefab, positoin, roadPrefab.transform.rotation);
        roadCurrent.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
