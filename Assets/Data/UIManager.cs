using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject bnGameOver;
    private void Awake()
    {
        instance = this;
        bnGameOver = GameObject.Find("bnGameOver");
        bnGameOver.SetActive(false);
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
