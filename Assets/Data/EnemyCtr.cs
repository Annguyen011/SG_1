using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtr : MonoBehaviour
{
    public DeSpawner spawner;
    private void Awake()
    {
        spawner = GetComponent<DeSpawner>();
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
