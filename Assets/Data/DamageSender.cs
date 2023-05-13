using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    public EnemyCtr enemy;
    private void Awake()
    {
        enemy = GetComponent<EnemyCtr>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver receiver = collision.GetComponent<DamageReceiver>();
        if (receiver == null) return;
        receiver.Receiver(1);
        Debug.Log(collision.name);
        enemy.spawner.DeSpawn();
    }
}
