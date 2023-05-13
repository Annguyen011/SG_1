using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    float randomPos = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.randomPos = Random.Range(-6, 6);
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        Vector3 pos = player.position;
        pos.x = randomPos;
        Vector3 distance = pos - transform.position;
        if (distance.magnitude >= 4f)
        {
            Vector3 target = player.position - distance.normalized * 4f;
            gameObject.transform.position =
                Vector3.MoveTowards(gameObject.transform.position, target, 30 * Time.fixedDeltaTime);
        }
    }
}
