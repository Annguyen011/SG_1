using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public PlayerCtrl playerCtrl;
    private void Awake()
    {
        playerCtrl = GetComponent<PlayerCtrl>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.CheckDead();
    }
    //public void CheckDead()
    //{
    //    if (playerCtrl.DamageReceiver.IsDead())
    //    {
    //        Dead();
    //    }
    //}
    public virtual void Dead()
    {
        Debug.Log("Dead");
    }
}
