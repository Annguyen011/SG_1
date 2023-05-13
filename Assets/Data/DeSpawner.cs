using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public void DeSpawn()
    {
        Destroy(gameObject);
    }
}
