using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReceiver : DamageReceiver
{
    public PlayerCtrl playerCtrl;
    private void Awake()
    {

        playerCtrl = GetComponent<PlayerCtrl>();
    }
    public override void Receiver(int dmg)
    {
        base.Receiver(dmg);
        if (this.IsDead())
        {
            playerCtrl.PlayerStatus.Dead();
            UIManager.instance.bnGameOver.SetActive(true);
        }
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
