using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public static PlayerCtrl instance;
    public DamageReceiver DamageReceiver;
    public PlayerStatus PlayerStatus;
    private void Awake()
    {
        instance = this;
        DamageReceiver = GetComponent<DamageReceiver>();
        PlayerStatus = GetComponent<PlayerStatus>();
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
