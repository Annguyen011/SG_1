using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDeSpawner : MonoBehaviour
{
    public float distance = 0f;
    private void FixedUpdate()
    {
        UpdateRoad();
    }
    public void UpdateRoad()
    {
        distance = Vector2.Distance(PlayerCtrl.instance.transform.position, transform.position);
        if (distance >= 70) Despawn();
    }
    public void Despawn()
    {
        Destroy(gameObject);
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
